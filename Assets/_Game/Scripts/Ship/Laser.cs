using Asteroids;
using UnityEngine;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [SerializeField] private float _speed = 0.2f;
        [SerializeField] private float _maxLifetime = 3f;
    
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

            UpdateLifetime();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (string.Equals(other.tag, "Asteroid"))
            {
                var asteroid = other.GetComponentInParent<Asteroid>();
            }
        }

        private void UpdateLifetime()
        {
            _lifetime += Time.fixedDeltaTime;

            if (_lifetime >= _maxLifetime)
            {
                Destroy(gameObject);
            }
        }
    }
}
