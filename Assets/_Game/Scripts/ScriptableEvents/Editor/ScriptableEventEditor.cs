using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DefaultNamespace.ScriptableEvents.Editor
{
    [CustomEditor(typeof(ScriptableEventBase), true)]
    public class ScriptableEventEditor : UnityEditor.Editor
    {
        private ScriptableEventBase _target;

        private List<int> _myList = new List<int>();
        private IntList _myOtherList = new IntList();
        
        public class IntList : List<int>
        {}

        public override void OnInspectorGUI()
        {
            _target = (ScriptableEventBase)target;

            base.OnInspectorGUI();

            if (GUILayout.Button("Debug Raise Event"))
            {
               _target.Raise();
            }

            using (new EditorGUILayout.HorizontalScope())
            {
                if (GUILayout.Button("Sub button one"))
                {
               
                }
            
                if (GUILayout.Button("Sub button two"))
                {
               
                }
                GUILayout.Label("My Label");
            }
            
            //var pos = new Rect(Vector2.zero, new Vector2(10f, 10f));
            //GUI.Button(pos, "My Other Button");

            // GUILayout
            // EditorGUI
            // EditorGUILayout
        }
    }
}
