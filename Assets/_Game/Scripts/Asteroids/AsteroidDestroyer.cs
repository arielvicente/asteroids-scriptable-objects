using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidSet : ScriptableObject
    {
        private Dictionary<int, Asteroid> _asteroids = new Dictionary<int, Asteroid>();

        private void Awake()
        {
            Clear();
        }

        public void Add()
        {
            
        }

        public void Remove()
        {
            
        }

        public Asteroid Get(int id)
        {
            return null;
        }

        private void Clear()
        {
            _asteroids = new Dictionary<int, Asteroid>();
        }
    }
    
    public class AsteroidDestroyer : MonoBehaviour
    {
        [SerializeField] private AsteroidSet _asteroids;

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
