using System;
using ScriptableEvents;
using UnityEngine;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "Variables/Observables/Float Observable")]
    public class FloatObservable : FloatVariable
    {
        [SerializeField] private ScriptableEventFloat _onValueChanged;
        
        public override void Set(float value)
        {
            base.Set(value);
            Raise();
        }

        public override void Set(FloatVariable variable)
        {
            base.Set(variable);
            Raise();
        }

        public override void ApplyChange(float amount)
        {
            base.ApplyChange(amount);
            Raise();
        }

        public override void ApplyChange(FloatVariable variable)
        {
            base.ApplyChange(variable);
            Raise();
        }
        
        private void Raise()
        {
            _onValueChanged.Raise(Value);
        }

        public void Register(Action<float> onValueChanged)
        {
            _onValueChanged.Register(onValueChanged);
        }

        public void Unregister(Action<float> onValueChanged)
        {
            _onValueChanged.Unregister(onValueChanged);
        }
    }
}
