using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Vars
{
    [Serializable]
    public class FloatRef
    {
        [SerializeField] private bool _useSimpleValue;
        
        [SerializeField] private FloatVar _variableNewName;
        [SerializeField] private float _simpleValue;

        public float Value => _useSimpleValue ? _simpleValue : _variableNewName.Value;

        #if UNITY_EDITOR
        public static string VariableName = nameof(_variableNewName);
        public static string UseSimpleValueName = nameof(_useSimpleValue); // "_useSimpleValue"
        public static string SimpleValueName = nameof(_simpleValue);
        #endif
    }
    
    /*
     
     private readonly string[] popupOptions = {"Use Constant", "Use Variable"};

        /// <summary> Cached style to use to draw the popup button. </summary>
        private GUIStyle popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            popupStyle ??= new GUIStyle(GUI.skin.GetStyle("PaneOptions"))
            {
                imagePosition = ImagePosition.ImageOnly
            };

            position = DrawPropertyName(position, property, label);

            EditorGUI.BeginChangeCheck();

            // Get properties
            SerializedProperty useConstant = property.FindPropertyRelative("_useConstant");
            SerializedProperty constantValue = property.FindPropertyRelative("_constantValue");
            SerializedProperty variable = property.FindPropertyRelative("_variable");

            // Calculate rect for configuration button
            Rect buttonRect = new Rect(position);
            buttonRect.yMin += popupStyle.margin.top;
            buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // Store old indent level and set it to 0, the PrefixLabel takes care of it
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            //useConstant.boolValue = ShowPopup(useConstant, buttonRect);

            EditorGUI.PropertyField(position,
                useConstant.boolValue ? constantValue : variable,
                GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private static Rect DrawPropertyName(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);
            return position;
        }

        private bool ShowPopup(SerializedProperty useConstant, Rect buttonRect)
        {
            var result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, popupOptions, popupStyle);
            return result == 0;
        } 
     */
}
