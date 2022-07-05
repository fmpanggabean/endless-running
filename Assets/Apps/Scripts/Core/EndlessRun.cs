using System;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Core {
    public class EndlessRun : MonoBehaviour {
        public GameManager gameManager;
        public UIManager uiManager;

        private void Awake() {
            new SharedEvent(gameManager, uiManager);
        }
    } 
}