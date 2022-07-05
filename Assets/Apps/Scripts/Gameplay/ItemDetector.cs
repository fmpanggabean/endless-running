using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace EndlessRunning.Gameplay {
    public class ItemDetector : MonoBehaviour {

        private void OnTriggerEnter(Collider other) {

            if (other.GetComponent<Item>()) {
                GameManager.instance.GetScore(1);
            }
        }
    } 
}
