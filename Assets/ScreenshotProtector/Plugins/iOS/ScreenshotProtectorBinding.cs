using System.Runtime.InteropServices;
using UnityEngine;

namespace ScreenshotProtection 
{
    public static class ScreenshotProtectorBinding
    {

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void EnableScreenshotProtection();

        [DllImport("__Internal")]
        private static extern void DisableScreenshotProtection();

        [DllImport("__Internal")]
        private static extern bool isScreenshotTaken();
#else
        // TODO: Android用の処理
        private static void EnableScreenshotProtection() { }
        private static void DisableScreenshotProtection() { }
        private static bool isScreenshotTaken() { return false; }
#endif

        public static void EnableProtection()
        {
            EnableScreenshotProtection();
        }

        public static void DisableProtection()
        {
            DisableScreenshotProtection();
        }

        public static bool IsScreenshotTaken()
        {
            return isScreenshotTaken();
        }
    }

}
