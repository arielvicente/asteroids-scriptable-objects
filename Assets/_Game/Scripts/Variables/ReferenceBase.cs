using System;
using UnityEngine;

namespace Variables
{
    [Serializable]
    public abstract class ReferenceBase<T, TVariable> where TVariable : VariableBase<T, TVariable>
    {
        [SerializeField] protected bool _useConstant = true;
        [SerializeField] protected T _constantValue;
        [SerializeField] protected TVariable _variable;

        public T GetValue()
        {
            return _useConstant ? _constantValue : _variable.Value;
        }
        
        public virtual void SetValue(T value)
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
        
        public virtual void SetValue(TVariable variable)
        {
            SetValue(variable.Value);
        }
    }
}
