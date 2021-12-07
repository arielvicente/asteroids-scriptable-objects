using System;
using UnityEngine;

namespace ScriptableEvents
{
    public abstract class ScriptableEventBase : ScriptableObject
    {
        private event Action OnEventNoValue;
        
        public void Raise()
        {
            OnEventNoValue?.Invoke();
        }
        
        public void Register(Action onEvent)
        {
            OnEventNoValue += onEvent;
        }

        public void Unregister(Action onEvent)
        {
            OnEventNoValue -= onEvent;
        }
        
        // 
        public virtual void UnregisterAll()
        {
            OnEventNoValue = null;
        }

    }
}

