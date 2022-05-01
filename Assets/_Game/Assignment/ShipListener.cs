
using UnityEngine;

namespace Assignment
{
    public class ShipListener : MonoBehaviour
    {
        public VoidEventChannelSO screenWrapChannelX;
        public VoidEventChannelSO screenWrapChannelY;
        void OnEnable()
        {
            screenWrapChannelX.OnEventRaised += ScreenWrapX;
            screenWrapChannelY.OnEventRaised += ScreenWrapY;
        }

        private void OnDisable()
        {
            screenWrapChannelX.OnEventRaised -= ScreenWrapX;
            screenWrapChannelY.OnEventRaised -= ScreenWrapY;
        }


       //the screenwrapping is a little bit buggy if you slowly approach the ends of the camera but i ran out of time
       //and i dont really know how to fix it beyond adding that tiny offset
        private void ScreenWrapX()
        {
            Vector3 newPositionX = transform.position;
            newPositionX.x = -newPositionX.x + 0.2f;

            transform.position = newPositionX;
        }

        private void ScreenWrapY()
        {
            Vector3 newPositionY = transform.position;
            newPositionY.y = -newPositionY.y + 0.2f;

            transform.position = newPositionY;
        }
    }
}
