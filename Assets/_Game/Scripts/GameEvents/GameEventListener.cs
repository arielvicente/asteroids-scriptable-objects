using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.GameEvents
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent _gameEvent;
        [SerializeField] private UnityEvent _response;
        
        private void OnEnable()
        {
            _gameEvent.Register(OnEventRaised);
        }

        private void OnDisable()
        {
            _gameEvent.Unregister(OnEventRaised);
        }

        public void OnEventRaised()
        {
           _response?.Invoke();
        }
    }
}
