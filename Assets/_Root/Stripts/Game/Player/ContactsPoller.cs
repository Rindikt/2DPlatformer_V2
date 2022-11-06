using UnityEngine;
using JoostenProductions;

namespace Game.Player
{
    internal sealed class ContactsPoller
    {
        private const float ColisionThresh = 0.1f;
        private readonly Collider2D _collider2D;

        private ContactPoint2D[] _contacts = new ContactPoint2D[10];

        public bool IsGround { get; private set; }
        public bool HasLeftContacts { get; private set; }
        public bool HasRightContacts { get; private set; }

        public ContactsPoller(Collider2D collider2D)
        {
            _collider2D = collider2D;
            UpdateManager.SubscribeToUpdate(Execute);
        }

        private void Execute()
        {
            IsGround = false;
            HasLeftContacts = false;
            HasRightContacts = false;

            var contactsCount = _collider2D.GetContacts(_contacts);

            for (int i = 0; i < contactsCount; i++)
            {
                var normal = _contacts[i].normal;
                var rigidbody = _contacts[i].rigidbody;

                if (normal.y > ColisionThresh)
                {
                    IsGround = true;
                    Debug.Log("JUMP");
                }

                if (normal.x>ColisionThresh && rigidbody == null)
                    HasLeftContacts = true;

                if (normal.x< - ColisionThresh && rigidbody == null)
                    HasRightContacts =true;

            }
        }
    }
}
