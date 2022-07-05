using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using EndlessRunning.Core;

namespace EndlessRunning.Gameplay {
    public class Item : MonoBehaviour {
        public int point = 10;

        private void OnEnable() {
            GameManager.instance.sharedEvent.onGetItem += Hide;
        }

        private void OnDisable() {
            GameManager.instance.sharedEvent.onGetItem -= Hide;
        }

        public void Hide(int score) {
            gameObject.SetActive(false);
        }
    } 
}
