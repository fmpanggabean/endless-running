using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EndlessRunning.UI {
    public class ScoreUI : MonoBehaviour {
        [SerializeField] private Text scoreText;

        private void Start() {
            UIManager.instance.sharedEvent.onScoreAdded += SetScore;
        }

        private void OnDisable() {
            UIManager.instance.sharedEvent.onScoreAdded -= SetScore;
        }

        public void SetScore(int score) {
            scoreText.text = score.ToString();
        }
    } 
}
