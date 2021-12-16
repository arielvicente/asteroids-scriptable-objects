using System;
using System.Collections.Generic;
using Ship;
using UnityEngine;

namespace RuntimeSets
{
    [CreateAssetMenu]
    public class LaserRuntimeSet : ScriptableObject
    {
        private readonly List<GameObject> _lasers = new List<GameObject>();

        public int Amount => _lasers.Count;
        
        public void Add(GameObject laser)
        {
            _lasers.Add(laser);
        }

        public void Remove(GameObject laser)
        {
            _lasers.Remove(laser);
        }

        // TODO Which is the best method to clear?
        private void OnEnable()
        {
            _lasers.Clear();
        }
    }
}
