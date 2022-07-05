using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class AutoMove : MonoBehaviour {
        private Movement movement;

        private void Awake() {
            movement = GetComponent<Movement>();
            movement.SetZDirection(-1);
        }

        private void Update() {
            movement.SetSpeed(GameManager.instance.GetSpeed());
        }
    } 
}
