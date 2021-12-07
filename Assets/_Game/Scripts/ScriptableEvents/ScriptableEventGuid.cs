using System;
using UnityEngine;

namespace ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEventGuid", menuName = "ScriptableEvents/Event-Guid")]
    public class ScriptableEventGuid : ScriptableEvent<Guid>
    {
    }
}
