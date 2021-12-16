using System;
using DefaultNamespace.GameEvents;
using TMPro;
using UnityEngine;

namespace DefaultNamespace.Vars
{
    public class MyMono : MonoBehaviour
    {
        [SerializeField] private FloatRef _myNewName;
        [SerializeField] private GameEvent _myEvent;
        

        //[SerializeField] private TextMeshProUGUI _text;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _myEvent.Raise();
            }
           //_text.text = _myFloatRef.Value.ToString();
        }

        public void MyMethod()
        {
            Debug.Log("My Method was called!");
        }

        public void OnMouseClicked(Vector3 value)
        {
            Debug.Log(value);
        }
        
    }
}
