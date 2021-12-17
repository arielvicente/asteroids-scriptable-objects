using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ElementSO : ScriptableObject
    {
        [Tooltip("The elements that are defeated by this element.")]
        public List<ElementSO> DefeatedElements = new List<ElementSO>();

        public string myString = "Hello!";
        public float myFloat = 13.37f;
    }
}
