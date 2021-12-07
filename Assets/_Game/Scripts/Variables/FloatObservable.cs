using System;

namespace Variables
{
    public class FloatObservable : FloatVariable
    {
        private event Action<float> _onValueChanged;

        public override void Set(float value)
        {
            base.Set(value); 
            _onValueChanged?.Invoke(Value);
        }
        
        public override void Set(FloatVariable variable)
        {
            base.Set(variable);
            _onValueChanged?.Invoke(Value);
        }

        public override void ApplyChange(float amount)
        {
            base.ApplyChange(amount);
            _onValueChanged?.Invoke(Value);
        }

        public override void ApplyChange(FloatVariable variable)
        {
            base.ApplyChange(variable);
            _onValueChanged?.Invoke(Value);
        }
        
        public void Raise()
        {
           _onValueChanged?.Invoke(Value);
        }
        
        public void Register(Action<float> onEvent)
        {
            _onValueChanged += onEvent;
        }
        
        public void Unregister(Action<float> onEvent)
        {
            _onValueChanged -= onEvent;
        }
    }
}
