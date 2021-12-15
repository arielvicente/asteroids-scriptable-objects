using System;
using UnityEngine;

namespace DefaultNamespace.Vars
{
    [CreateAssetMenu(fileName = "new FloatVar", menuName = "SOs/Float Var")]
    public class FloatVar : ScriptableObject
    {
        [Range(0f, 20f)]
        [SerializeField] private float _value;

        [TextArea(3, 6)]
        [SerializeField] private string _developerDescription;
        
        public float Value => _value;

        private float _currentValue;

        private void OnEnable()
        {
            _currentValue = _value;
        }
    }
}
