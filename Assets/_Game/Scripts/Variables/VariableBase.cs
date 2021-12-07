using UnityEngine;

namespace Variables
{
    public abstract class VariableBase<T> : ScriptableObject
    {
        [SerializeField] protected T _value;

        public T Value => _value;
    }
    
    public abstract class VariableBase<T, TVariable> : VariableBase<T> where TVariable : VariableBase<T>
    {
        public virtual void Set(T value)
        {
            _value = value;
        }

        public virtual void Set(TVariable variable)
        {
            _value = variable.Value;
        }
    }
}
