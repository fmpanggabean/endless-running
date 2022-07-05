using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Core {
    public class GameManager : MonoBehaviour {
        public static GameManager instance;
        public SharedEvent sharedEvent;
        public InputHandler input;

        [SerializeField]
        [Range(0, 100)]
        private float speed;
        [SerializeField]
        private int score;
        [SerializeField]
        private float distance;

        private void Awake() {
            if (instance == null) {
                instance = this;
            }
            else {
                Destroy(gameObject);
            }
        }

        private void Start() {
            Time.timeScale = 0;
        }

        private void Update() {
            AddDistance(speed * Time.deltaTime);
        }

        private void OnEnable() {
            sharedEvent.onGetItem += AddScore;
            sharedEvent.onGameStart += StartGame;
            sharedEvent.onPauseGame += PauseGame;
            sharedEvent.onResumeGame += ResumeGame;

            input.onPausePressed += sharedEvent.onPauseGame;
        }

        private void OnDisable() {
            sharedEvent.onGetItem -= AddScore;
            sharedEvent.onGameStart -= StartGame;
            sharedEvent.onPauseGame -= PauseGame;
            sharedEvent.onResumeGame -= ResumeGame;
        }

        public float GetSpeed() {
            return speed;
        }

        public void AddScore(int value) {
            score += value;
            sharedEvent.onScoreAdded?.Invoke(score);
        }

        public void AddDistance(float _distance) {
            distance += _distance;
            sharedEvent.onDistanceAdded?.Invoke(distance);
        }

        private void StartGame() {
            Debug.Log("start game");
            input.EnableInput(InputState.Gameplay);
            speed = 20;
            Time.timeScale = 1;
        }

        private void PauseGame() {
            Time.timeScale = 0;
            input.EnableInput(InputState.UI);
        }

        private void ResumeGame() {
            input.EnableInput(InputState.Gameplay);
            Time.timeScale = 1;
        }
    } 
}
