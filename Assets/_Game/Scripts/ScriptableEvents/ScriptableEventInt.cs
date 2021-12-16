using UnityEngine;

namespace DefaultNamespace.ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEventInt", menuName = "ScriptableObjects/ScriptableEvent-Int", order = 0)]
    public class ScriptableEventInt : ScriptableEvent<int>
    {
        
    }
    
    public class ScriptableEventVector3 : ScriptableEvent<Vector3>
    {
        
    } 
}
