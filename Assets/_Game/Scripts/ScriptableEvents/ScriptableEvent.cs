using System;
using UnityEngine;

namespace ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEvent", menuName = "ScriptableEvents/Event")]
    public class ScriptableEvent : ScriptableEventBase
    {
    }
    
    public abstract class ScriptableEvent<TPayload> : ScriptableEventBase
    {
        private Action<TPayload> _onEvent;
        
        public void Raise(TPayload payload)
        {
            base.Raise();
            
           _onEvent?.Invoke(payload);
        }
        
        public void Register(Action<TPayload> onEvent)
        {
            _onEvent += onEvent;
        }

        public void Unregister(Action<TPayload> onEvent)
        {
            _onEvent -= onEvent;
        }
    }
}
