using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidSet : ScriptableObject
    {
        
    }
    
    public class AsteroidDestroyer : MonoBehaviour
    {
        private List<Asteroid> _asteroids;
        private List<int> _asteroidIds;

        private Dictionary<int, Asteroid> _asteroidDict;

        public void OnAsteroidHitByLaser(int asteroidId)
        {
            // Get the asteroid
            
            // Check if big or small
            
            // if small enough, we Destoy
            
            // if it's big, we split it up.
        }

        public void RegisterAsteroid(Asteroid asteroid)
        {
            
        }

        private void DestroyAsteroid(Asteroid asteroid)
        {
            //_asteroids.Remove()
        }
    }
}
