using UnityEngine;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
               
            }
        }
    }
}
