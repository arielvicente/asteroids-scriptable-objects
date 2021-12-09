using System;

namespace Variables
{
    [Serializable]
    public class FloatReference : ReferenceBase<float, FloatVariable>
    {
        public FloatReference() { }

        public FloatReference(float value)
        {
            _useConstant = true;
            _constantValue = value;
        } 
        
        public static implicit operator float(FloatReference reference)
        {
            return reference.GetValue();
        }
    }
}
