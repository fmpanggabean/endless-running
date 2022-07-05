using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class TerrainPool : MonoBehaviour {
        public PoolInfo poolInfo;
        private List<GameObject> terrainContainer;

        private void Awake() {
            terrainContainer = new List<GameObject>();
        }

        private void Start() {
            GenerateObject();
        }

        private void Update() {
            PlacementUpdate();
        }

        private void PlacementUpdate() {
            int index = 0;
            foreach(GameObject go in terrainContainer) {
                if (go.transform.position.z <= poolInfo.vanishingPoint.z) {
                    go.transform.position = terrainContainer[index - 1 >= 0 ? index - 1 : poolInfo.poolSize - 1].transform.position + poolInfo.objectOffset;
                    break;
                }
                index++;
            }
        }

        private void GenerateObject() {
            for (int i=0; i<poolInfo.poolSize; i++) {
                terrainContainer.Add(Instantiate(poolInfo.prefab, poolInfo.GetObjectPosition(i), Quaternion.identity));
            }
        }
    } 
}
