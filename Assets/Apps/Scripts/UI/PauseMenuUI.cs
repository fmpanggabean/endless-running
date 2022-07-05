using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EndlessRunning.Core;

namespace EndlessRunning.UI {
    public class PauseMenuUI : MonoBehaviour {
        public GameObject pauseWindow;
        public Button resumeButton;

        private void Start() {

            UIManager.instance.sharedEvent.onResumeGame += Hide;
            UIManager.instance.sharedEvent.onPauseGame += Show;

            UIManager.instance.SetPauseEvent(UIManager.instance.sharedEvent.onPauseGame);
            resumeButton.onClick.AddListener(UIManager.instance.sharedEvent.onResumeGame.Invoke);

            Hide();
        }

        private void Hide() {
            pauseWindow.SetActive(false);
        }

        private void Show() {
            pauseWindow.SetActive(true);
        }
    }
}

