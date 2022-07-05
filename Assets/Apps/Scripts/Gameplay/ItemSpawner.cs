using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Gameplay {
    public class ItemSpawner : MonoBehaviour {
        public GameObject objectToSpawn;
        public Transform[] anchor;
        public event Action onSpawn;
        public float delay;
        public List<AutoMove> itemPool;

        private void Awake() {
            itemPool = new List<AutoMove>();
        }

        private void Start() {
            GenerateItem();
            StartSpawning();
        }

        private void GenerateItem() {
            for (int i=0;i<10; i++) {
                itemPool.Add( Instantiate(objectToSpawn, transform).GetComponent<AutoMove>() );
                itemPool[i].gameObject.SetActive(false);
            }
        }

        private void OnEnable() {
            onSpawn += Spawn;
        }

        private void OnDisable() {
            onSpawn -= Spawn;
        }

        public void StartSpawning() {
            StartCoroutine(SpawnCoroutine());
            
        }

        private IEnumerator SpawnCoroutine() {
            while (true) {
                onSpawn?.Invoke();

                yield return new WaitForSeconds(delay);
            }
        }

        private void Spawn() {
            foreach(AutoMove item in itemPool) {
                if (!item.gameObject.activeSelf) {
                    item.gameObject.SetActive(true);
                    item.transform.position = anchor[GetRandomIndex()].position;

                    break;
                }
            }
        }

        private int GetRandomIndex() {
            return UnityEngine.Random.Range(0, anchor.Length);
        }
    } 
}
