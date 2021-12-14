using UnityEngine;
using Variables;

namespace DefaultNamespace.ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEventInt", menuName = "ScriptableObjects/ScriptableEvent-Int", order = 0)]
    public class ScriptableEventInt : ScriptableEvent<IntReference>
    {
        public void Raise(int newValue)
        {
            Raise(new IntReference(newValue));
        }
    }
}
