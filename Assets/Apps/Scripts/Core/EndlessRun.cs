using System;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Core {
    public class EndlessRun : MonoBehaviour {
        public GameManager gameManager;
        public UIManager uiManager;

        private SharedEvent sh;

        private void Awake() {
            sh = new SharedEvent();
            gameManager.sharedEvent = sh;
            uiManager.sharedEvent = sh;
        }
    } 
}