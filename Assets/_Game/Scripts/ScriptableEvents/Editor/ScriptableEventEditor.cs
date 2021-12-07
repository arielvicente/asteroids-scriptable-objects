using ScriptableEvents;
using UnityEditor;
using UnityEngine;

namespace _Game.Scripts.ScriptableEvents.Editor
{
    [CustomEditor(typeof(ScriptableEvent), true)]
    public class ScriptableEventEditor : UnityEditor.Editor
    {
        private ScriptableEvent _myTarget;
        
        public override void OnInspectorGUI()
        {
            _myTarget = (ScriptableEvent)target;
            
            base.OnInspectorGUI();
            if (GUILayout.Button("Raise Event Debug"))
            {
                _myTarget.Raise();
            }
        }
    }
}
