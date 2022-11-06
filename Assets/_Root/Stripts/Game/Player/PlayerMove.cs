using JoostenProductions;
using UnityEngine;

namespace Game.Player
{
    internal class PlayerMove
    {
        private PlayerView _playerView;
        private Rigidbody2D _rigidbody;
        private Animator _animator;
        private ContactsPoller _contactsPoller;
        public PlayerMove(PlayerView playerView)
        {
            UpdateManager.SubscribeToUpdate(Move);
            _playerView = playerView;
            _rigidbody = playerView.Rigidbody;
            _animator = playerView.Animator;
            _contactsPoller = new ContactsPoller(_playerView.CapsuleCollider);
        }
        private void Move()
        {
            float derection = Input.GetAxis(StringManager.HORIZONTAL);
            _rigidbody.velocity = new Vector2(derection * _playerView.Speed, _rigidbody.velocity.y);
            _playerView.SpriteRenderer.flipX = (derection < 0);
            _animator.SetBool(StringManager.RUN, derection != 0 && _contactsPoller.IsGround);
            _animator.SetBool(StringManager.JUMP, _contactsPoller.IsGround);

            if (Input.GetKey(KeyCode.Space)&& _contactsPoller.IsGround)
                Jump();
               
        }

        private void Jump()
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _playerView.ForceJump);

        }
    }
}
