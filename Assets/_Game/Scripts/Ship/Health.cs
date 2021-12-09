using UnityEngine;
using FloatReference = Variables.FloatReference;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private FloatReference _health;

        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            //_health.Value = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
