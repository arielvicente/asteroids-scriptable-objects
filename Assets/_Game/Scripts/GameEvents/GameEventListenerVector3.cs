using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.GameEvents
{
    public class GameEventListenerVector3 : MonoBehaviour
    {
        [SerializeField] private GameEventVector3 _gameEvent;
        [SerializeField] private UnityEvent<Vector3> _response;
        
        private void OnEnable()
        {
            _gameEvent.Register(OnEventRaised);
        }

        private void OnDisable()
        {
            _gameEvent.Unregister(OnEventRaised);
        }

        private void OnEventRaised(Vector3 value)
        {
            _response?.Invoke(value);
        }
    }
}
