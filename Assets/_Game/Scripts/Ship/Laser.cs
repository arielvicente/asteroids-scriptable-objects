using System;
using Asteroids;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [Header("Events:")]
        [SerializeField]
        private ScriptableEventInt _onLaserHitAsteroidEvent;
        
        
        [Header("Values:")]
        [SerializeField] private float _speed = 0.2f;

        private Rigidbody2D _rigidbody;
        private float _lifetime;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        private void FixedUpdate()
        {
            var trans = transform;
            _rigidbody.MovePosition(trans.position + trans.up * _speed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (string.Equals(other.tag, "Asteroid"))
            {
                var asteroid = other.GetComponentInParent<Asteroid>();
                var id = asteroid.GetInstanceID();
                _onLaserHitAsteroidEvent.Raise(id);
            }
        }
    }
}
