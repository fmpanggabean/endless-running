using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunning.Base;

namespace EndlessRunning.UI {
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
    }

}