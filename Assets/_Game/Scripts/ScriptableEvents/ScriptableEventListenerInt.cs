using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.ScriptableEvents
{
    public class ScriptableEventListenerInt : ScriptableEventListener<int, ScriptableEventInt, UnityEvent<int>>
    {
       
    }

    [Serializable]
    public class UnityEventInt : UnityEvent<int>
    {
        
    }
}
