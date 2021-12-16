using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.GameEvents
{
    [CreateAssetMenu(fileName = "new Vector3 event", menuName = "ScriptableObjects/Events/VectorEvent", order = 0)]
    public class GameEventVector3 : ScriptableObject
    {
        private event Action<Vector3> _event;

        public void Raise(Vector3 value)
        {
            _event?.Invoke(value);
        }
        
        public void Register(Action<Vector3> onEvent)
        {
            _event += onEvent;
        }
        
        public void Unregister(Action<Vector3> onEvent)
        {
            _event -= onEvent;
        }
    }
}
