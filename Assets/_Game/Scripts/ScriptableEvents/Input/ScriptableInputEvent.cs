using UnityEngine;

namespace ScriptableEvents.Input
{
    [CreateAssetMenu(fileName = "new GameInputEvent", menuName = "ScriptableEvents/InputEvent")]
    public class ScriptableInputEvent : ScriptableEvent
    {
        public KeyCode Key => _key;
        public InputType InputType => _type;
        public PollingType Polling => _polling;

        [SerializeField] private KeyCode _key;
        [SerializeField] private InputType _type;
        [SerializeField] private PollingType _polling;
    }
}
