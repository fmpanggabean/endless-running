using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class PlayerMovement : Movement {
        public InputHandler inputHandler;
        
        private void Start() {

        }
        private void OnEnable() {
            inputHandler.onPlayerMovementPressed += SetXDirection;
        }
        private void OnDisable() {
            inputHandler.onPlayerMovementPressed -= SetXDirection;
        }
    } 
}
