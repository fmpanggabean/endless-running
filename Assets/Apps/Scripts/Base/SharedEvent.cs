using System;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunning.Base {
    public class SharedEvent {
        public Action<int> onGetItem;
        public Action<int> onScoreAdded;
        public Action<float> onDistanceAdded;
        public Action onGameStart;
        public Action onPauseGame;
        public Action onResumeGame;
    }  
}
