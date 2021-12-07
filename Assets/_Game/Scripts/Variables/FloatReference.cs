using System;
using UnityEngine;

namespace Variables
{
    public abstract class ReferenceBase<T>
    {
        [SerializeField] private bool _useConstant = true;
        [SerializeField] private float _constantValue;
        [SerializeField] private FloatVariable _variable;
    }
    
    [Serializable]
    public class FloatReference
    {
        [SerializeField] private bool _useConstant = true;
        [SerializeField] private float _constantValue;
        [SerializeField] private FloatVariable _variable;
        
        public float Value 
        {
            get => _useConstant ? _constantValue : _variable.Value;
            set
            {
                if (_useConstant)
                {
                    _constantValue = value;
                }
                else
                {
                    _variable.Set(value);
                }
            }
        }
        public FloatReference() { }

        public FloatReference(float value)
        {
            _useConstant = true;
            _constantValue = value;
        }

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }
    }
}
