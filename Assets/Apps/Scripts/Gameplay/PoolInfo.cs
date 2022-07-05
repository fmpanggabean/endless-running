using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    [CreateAssetMenu(fileName = "New Pool Info", menuName = "Game Data/Pool Information")]
    public class PoolInfo : ScriptableObject {
        public int poolSize;
        public Vector3 objectOffset;
        public Vector3 startingPoint;
        public Vector3 vanishingPoint;
        public GameObject prefab;

        internal Vector3 GetObjectPosition(int i) {
            return startingPoint + (objectOffset * i);
        }
    } 
}
