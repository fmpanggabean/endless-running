using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using EndlessRunning.Core;

namespace EndlessRunning.Gameplay {
    public class ItemDetector : MonoBehaviour {

        private void OnTriggerEnter(Collider other) {

            if (other.GetComponent<Item>()) {
                GameManager.instance.sharedEvent.onGetItem?.Invoke(other.GetComponent<Item>().point);
            }
        }
    } 
}
