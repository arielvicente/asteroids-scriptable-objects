using System;
using UnityEngine.Events;

namespace ScriptableEvents
{
    public class ScriptableEventListenerGuid : ScriptableEventListener<Guid, ScriptableEventGuid, UnityEventGuid>
    {
    }

    [Serializable]
    public class UnityEventGuid : UnityEvent<Guid>
    {
        
    }
}
