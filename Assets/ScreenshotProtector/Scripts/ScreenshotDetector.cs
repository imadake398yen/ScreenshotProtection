using UnityEngine;
using UnityEngine.UI;

namespace ScreenshotProtection.Demo 
{
    public class ScreenshotDetector : MonoBehaviour
    {

        private void Start()
        {
            ScreenshotProtectorBinding.EnableProtection();
        }

        private void Update()
        {
            if (ScreenshotProtectorBinding.IsScreenshotTaken())
            {
                AlertModal.Open();
            }
        }

    }
}

