using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class PlayerMovement : Movement {
        public InputHandler inputHandler;
        public Vector3[] lanes;
        [SerializeField] private int currentLane;
        
        private void Start() {
            currentLane = 1;
        }

        new private void Update() {
            base.Update();

            if (transform.position.x < GetCurrentLanePosition().x) {
                SetXDirection(1);
            } else if (transform.position.x > GetCurrentLanePosition().x) {
                SetXDirection(-1);
            }

            if ((transform.position - GetCurrentLanePosition()).magnitude < 0.1f) {
                transform.position = GetCurrentLanePosition();
            }
        }

        private Vector3 GetCurrentLanePosition() {
            return lanes[currentLane];
        }

        private void SetDirection(float _direction) {
            currentLane += (int)_direction;

            if (currentLane > 2) currentLane = 2;
            else if (currentLane < 0) currentLane = 0;
        }

        private void OnEnable() {
            inputHandler.onPlayerMovementPressed += SetDirection;
        }
        private void OnDisable() {
            inputHandler.onPlayerMovementPressed -= SetDirection;
        }
    } 
}
