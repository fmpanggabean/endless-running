using System;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunning.Gameplay;
using EndlessRunning.UI;

namespace EndlessRunning.Base {
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