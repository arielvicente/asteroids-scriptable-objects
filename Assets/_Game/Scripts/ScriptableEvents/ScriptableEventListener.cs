using UnityEngine;
using UnityEngine.Events;


namespace ScriptableEvents
{
    public class ScriptableEventListener : MonoBehaviour
    {
       [SerializeField] private ScriptableEvent _eventNoPayload;
       [SerializeField] private UnityEvent _responseNoPayload;

       protected virtual void OnEnable()
        {
            if (_eventNoPayload == null)
            {
                return;
            }
            
            _eventNoPayload.Register(OnEventRaised);
        }

        protected virtual void OnDisable()
        {
            if (_eventNoPayload == null)
            {
                return;
            }
            
            _eventNoPayload.Unregister(OnEventRaised);
        }

        protected void OnEventRaised()
        {
            _responseNoPayload.Invoke();
        }
    }
    
    public abstract class ScriptableEventListener<TPayload, TEvent, TUnityEventResponse> : ScriptableEventListener
        where TEvent : ScriptableEvent<TPayload>
        where TUnityEventResponse : UnityEvent<TPayload>
    {
        [SerializeField] private TEvent _event;
        [SerializeField] private TUnityEventResponse _response;
        
        protected override void OnEnable()
        {
            _event.Register(OnEventRaised);
        }

        protected override void OnDisable()
        {
            _event.Unregister(OnEventRaised);
        }
        
        private void OnEventRaised(TPayload payload)
        {
            base.OnEventRaised();
            _response.Invoke(payload);
        }
    }
}
