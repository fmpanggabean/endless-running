using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EndlessRunning.UI {
    public class StartMenuUI : MonoBehaviour {
        public Button startButton;

        private void Start() {
            UIManager.instance.sharedEvent.onGameStart += Hide;

            startButton.onClick.AddListener(UIManager.instance.sharedEvent.onGameStart.Invoke);
        }

        private void Hide() {
            gameObject.SetActive(false);
        }
    } 
}
