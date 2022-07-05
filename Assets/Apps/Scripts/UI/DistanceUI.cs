using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EndlessRunning.UI {
    public class DistanceUI : MonoBehaviour {
        [SerializeField] private Text distanceText;

        private void Start() {
            UIManager.instance.sharedEvent.onDistanceAdded += DistanceUpdate;
        }

        private void OnDisable() {
            UIManager.instance.sharedEvent.onDistanceAdded -= DistanceUpdate;
        }

        private void DistanceUpdate(float _distance) {
            distanceText.text = _distance.ToString("000000");
        }
    } 
}
