using System;
using UnityEditor;
using UnityEngine;

namespace RuntimeSets.Editor
{
    [CustomEditor(typeof(LaserRuntimeSet))]
    public class LaserRuntimeSetEditor : UnityEditor.Editor
    {
        private LaserRuntimeSet _target;
        private int _amount;

        public override bool RequiresConstantRepaint()
        {
            _target = (LaserRuntimeSet)target;

            if (_amount == _target.Amount)
            {
                return false;
            }

            return true;
        }
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            _target = (LaserRuntimeSet)target;
            _amount = _target.Amount;

            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.LabelField($"Amount of Lasers: {_amount}");
            }
        }
    }
}
