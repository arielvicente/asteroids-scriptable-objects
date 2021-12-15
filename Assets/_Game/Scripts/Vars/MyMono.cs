using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace.Vars
{
    public class MyMono : MonoBehaviour
    {
        [SerializeField] private FloatRef _myNewName;

        //[SerializeField] private TextMeshProUGUI _text;

        public void Update()
        {
           //_text.text = _myFloatRef.Value.ToString();
        }
    }
}
