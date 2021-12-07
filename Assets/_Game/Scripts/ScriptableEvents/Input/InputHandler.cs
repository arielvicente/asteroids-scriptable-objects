using System.Linq;
using UnityEngine;

namespace ScriptableEvents.Input
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private ScriptableInputEvent[] _inputEvents;

        private ScriptableInputEvent[] _updateEvents;
        private ScriptableInputEvent[] _fixedUpdateEvents;

        private void Awake()
        {
            _updateEvents = _inputEvents.Where(sEvent => sEvent.Polling == PollingType.Update).ToArray();
            _fixedUpdateEvents = _inputEvents.Where(sEvent => sEvent.Polling == PollingType.FixedUpdate).ToArray();
        }

        private void Update()
        {
            if (!UnityEngine.Input.anyKey)
                return;
            
            foreach (var inputEvent in _updateEvents)
                CheckKey(inputEvent);
        }
        
        private void FixedUpdate()
        {
            if (!UnityEngine.Input.anyKey)
                return;
            
            foreach (var inputEvent in _fixedUpdateEvents)
                CheckKey(inputEvent);
        }

        private static void CheckKey(ScriptableInputEvent inputEvent)
        {
            if (inputEvent.InputType == InputType.OnPress)
            {
                if (UnityEngine.Input.GetKeyDown(inputEvent.Key))
                    inputEvent.Raise();
            }
            else if (inputEvent.InputType == InputType.OnHold)
            {
                if (UnityEngine.Input.GetKey(inputEvent.Key))
                    inputEvent.Raise();
            }
        }
    }
}
