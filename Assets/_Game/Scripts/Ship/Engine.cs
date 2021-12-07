using UnityEngine;
using Variables;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Engine : MonoBehaviour
    {
        [SerializeField] private FloatReference _throttlePower;
        [SerializeField] private FloatReference _rotationPower;
        
        private Rigidbody2D _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        public void Throttle()
        {
            _rigidbody.AddForce(transform.up * _throttlePower, ForceMode2D.Force);
        }

        public void SteerLeft()
        {
            _rigidbody.AddTorque(_rotationPower, ForceMode2D.Force);
        }

        public void SteerRight()
        {
            _rigidbody.AddTorque(-_rotationPower, ForceMode2D.Force);
        }
    
        private void FixedUpdate()
        {
            return;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rigidbody.AddForce(transform.up * _throttlePower, ForceMode2D.Force);
            }
        
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rigidbody.AddTorque(1f, ForceMode2D.Force);
            } 
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                _rigidbody.AddTorque(-1f, ForceMode2D.Force);
            }
        }
    }
}
