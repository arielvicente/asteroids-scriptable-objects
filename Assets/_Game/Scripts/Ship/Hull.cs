using ScriptableEvents;
using UnityEngine;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        [SerializeField] private ScriptableEvent _event;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                _event.Raise();
            }
        }
    }
}
