using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class Movement : MonoBehaviour {
        [SerializeField] private float speed;
        private Vector3 direction;

        protected void Update() {
            UpdatePosition();
        }

        private void UpdatePosition() {
            transform.position += GetOffset();
        }

        internal void SetSpeed(float v) {
            speed = v;
        }

        public Vector3 GetOffset() {
            return direction * Time.deltaTime * speed;
        }
        public void SetXDirection(float _direction) {
            direction.x = _direction;
        }
        public void SetZDirection(float _direction) {
            direction.z = _direction;
        }
    } 
}
