using System;
using UnityEngine;

namespace Variables
{
    [Serializable]
    public class IntReference
    {
        // TODO Can we make this look nicer with a custom property drawer?
        [SerializeField] private IntVariable _intVariable;
        [SerializeField] private int _simpleValue;
        [SerializeField] private bool _useSimple;

        public int GetValue()
        {
            return _useSimple ? _simpleValue : _intVariable.Value;
        }
        public void ApplyChange(int change)
        {
            if (_useSimple)
            {
                _simpleValue += change;
            }
            else
            {
                _intVariable.ApplyChange(change);
            }
        }
    }
}
