using System;
using UnityEngine;

namespace Game.Player
{
    internal class PlayerView : MonoBehaviour
    {
        public event Action<Collider2D> colesion;

        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _speed;
        [SerializeField] private float _forceJump;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Animator _animator;
        [SerializeField] private CapsuleCollider2D _capsuleCollider;

        public Rigidbody2D Rigidbody { get => _rigidbody; }
        public float Speed { get => _speed;}
        public SpriteRenderer SpriteRenderer { get => _spriteRenderer;}
        public Animator Animator { get => _animator;}
        public CapsuleCollider2D CapsuleCollider { get => _capsuleCollider;}
        public float ForceJump { get => _forceJump;}

        private void OnTriggerEnter2D(Collider2D collision)
        {
            colesion?.Invoke(collision);
        }

    }
}
