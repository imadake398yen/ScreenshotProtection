using System.Runtime.InteropServices;
using UnityEngine;

public class ScreenshotProtector : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void EnableScreenshotProtection();

    [DllImport("__Internal")]
    private static extern void DisableScreenshotProtection();

    private void Awake () {
        EnableProtection();
    }

    // 保護を有効にする
    public void EnableProtection()
    {
        EnableScreenshotProtection();
    }

    // 保護を無効にする
    public void DisableProtection()
    {
        DisableScreenshotProtection();
    }
}
