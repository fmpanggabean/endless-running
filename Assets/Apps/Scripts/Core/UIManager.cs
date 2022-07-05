using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Core {
    public class UIManager : MonoBehaviour {
        public static UIManager instance;
        public SharedEvent sharedEvent;
        public InputHandler input;

        private void Awake() {
            if (instance == null) {
                instance = this;
            }
            else {
                Destroy(gameObject);
            }
        }

        public void SetPauseEvent(Action onPauseGame) {
            input.onPausePressed += onPauseGame;
        }
    }

}