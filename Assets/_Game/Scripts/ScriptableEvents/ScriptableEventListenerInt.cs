using System;
using UnityEngine;
using UnityEngine.Events;
using Variables;

namespace DefaultNamespace.ScriptableEvents
{
    public class ScriptableEventListenerInt : ScriptableEventListener<IntReference, ScriptableEventInt, UnityEvent<IntReference>>
    {
       
    }

    [Serializable]
    public class UnityEventInt : UnityEvent<int>
    {
        
    }
}
