using UnityEngine;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "Variables/Float Variable")]
    public class FloatVariable :  VariableBase<float, FloatVariable>
    {
        public virtual void ApplyChange(float amount)
        {
            _value += amount;
        }

        public virtual void ApplyChange(FloatVariable variable)
        {
            _value += variable.Value;
        }
    }
}
