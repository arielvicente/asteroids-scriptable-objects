
using UnityEngine;

namespace Assignment
{
    public class ScreenBounds : MonoBehaviour
    {
        public VoidEventChannelSO screenWrapChannelX;
        public VoidEventChannelSO screenWrapChannelY;
        public Camera mainCamera;
        [SerializeField] private Renderer[] _renderers;

        private bool IsWrappingX = false;
        private bool IsWrappingY = false;
        
        bool CheckRenderers()
        {
            foreach (var renderer in _renderers)
            {
                if (renderer.isVisible)
                {
                    return true;
                }
            }

            return false;
        }

        private void Update()
        {
            Wrapping();
        }
        
        private void Wrapping()
        {
            bool isVisible = CheckRenderers();

            if (isVisible)
            {
                IsWrappingY = false;    
                IsWrappingX = false;
                return;
            }

            if (IsWrappingX && IsWrappingY)
            {
                return;
            }
            
            var viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
            if (viewportPosition.x > 1 ||  viewportPosition.x < 0)
            {
                screenWrapChannelX.RaiseEvent();
            }
            
            if ( viewportPosition.y > 1 || viewportPosition.y < 0)
            {
                screenWrapChannelY.RaiseEvent();
            }
            
            
        }
    }
}
