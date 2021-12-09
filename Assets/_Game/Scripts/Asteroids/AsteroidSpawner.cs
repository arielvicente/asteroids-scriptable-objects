using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public class AsteroidSpawner : MonoBehaviour
    {
        [SerializeField] private Asteroid _asteroidPrefab;
        [SerializeField] private float _minSpawnTime;
        [SerializeField] private float _maxSpawnTime;
        [SerializeField] private int _minAmount;
        [SerializeField] private int _maxAmount;
        
        private float _timer;
        private float _nextSpawnTime;
        private Camera _camera;

        private enum StartLocation
        {
            Top,
            Bottom,
            Left,
            Right
        }

        private void Start()
        {
            _camera = Camera.main;
            Spawn();
            UpdateNextSpawnTime();
        }

        private void Update()
        {
            UpdateTimer();

            if (!ShouldSpawn())
                return;

            Spawn();
            UpdateNextSpawnTime();
            _timer = 0f;
        }

        private void UpdateNextSpawnTime()
        {
            _nextSpawnTime = Random.Range(_minSpawnTime, _maxSpawnTime);
        }

        private void UpdateTimer()
        {
            _timer += Time.deltaTime;
        }

        private bool ShouldSpawn()
        {
            return _timer >= _nextSpawnTime;
        }

        private void Spawn()
        {
            var amount = Random.Range(_minAmount, _maxAmount + 1);
            
            for (var i = 0; i < amount; i++)
            {
                var location = GetStartLocation();
                var position = GetStartPosition(location);
                Instantiate(_asteroidPrefab, position, Quaternion.identity);
            }
        }

        private static StartLocation GetStartLocation()
        {
            var roll = Random.Range(0, 4);

            return roll switch
            {
                1 => StartLocation.Bottom,
                2 => StartLocation.Left,
                3 => StartLocation.Right,
                _ => StartLocation.Top
            };
        }

        private Vector3 GetStartPosition(StartLocation startLocation)
        {
            var pos = new Vector3 { z = Mathf.Abs(_camera.transform.position.z) };
            
            const float padding = 5f;
            switch (startLocation)
            {
                case StartLocation.Top:
                    pos.x = Random.Range(0f, Screen.width);
                    pos.y = Screen.height + padding;
                    break;
                case StartLocation.Bottom:
                    pos.x = Random.Range(0f, Screen.width);
                    pos.y = 0f - padding;
                    break;
                case StartLocation.Left:
                    pos.x = 0f - padding;
                    pos.y = Random.Range(0f, Screen.height);
                    break;
                case StartLocation.Right:
                    pos.x = Screen.width - padding;
                    pos.y = Random.Range(0f, Screen.height);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(startLocation), startLocation, null);
            }
            
            return _camera.ScreenToWorldPoint(pos);
        }
    }
}
