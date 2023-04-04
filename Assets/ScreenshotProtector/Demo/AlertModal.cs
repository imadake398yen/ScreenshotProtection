using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScreenshotProtection.Demo
{
    public class AlertModal : MonoBehaviour
    {

        public static AlertModal Instance { get; private set; }
        [SerializeField] private Button closeButton;

        private void Awake()
        {
            Instance = this;
            closeButton.onClick.AddListener(Close);
            Close();
        }

        public static void Open()
        {
            Instance.gameObject.SetActive(true);
        }

        private void Close()
        {
            gameObject.SetActive(false);
        }

    }
}