using System;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Core {
    public class EndlessRun : MonoBehaviour {
        private SharedEvent sharedEvent;

        public GameManager gameManager;
        public UIManager uiManager;

        private void Awake() {
            sharedEvent = new SharedEvent();

            gameManager.sharedEvent = sharedEvent;
            uiManager.sharedEvent = sharedEvent;
        }
    } 
}