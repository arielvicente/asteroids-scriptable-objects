using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.GameEvents
{
    [CreateAssetMenu(fileName = "new GameEvent", menuName = "ScriptableObjects/Events/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> _listeners = new List<GameEventListener>();
        private event Action _event;

        public void Raise()
        {
            for (var i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised();
            }

            _event?.Invoke();
        }

        public void Register(GameEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void Register(Action onEvent)
        {
            _event += onEvent;
        }

        public void Unregister(GameEventListener listener)
        {
            _listeners.Remove(listener);
        }
        
        public void Unregister(Action onEvent)
        {
            _event -= onEvent;
        }
    }
}
