using UnityEngine;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;
    
        public void Shoot()
        {
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
        }
    }
}
