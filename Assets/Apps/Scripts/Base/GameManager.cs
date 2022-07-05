using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IManager {
    public static GameManager instance;
    public IMediator mediator;

    [Range(0, 100)]
    public float scrollSpeed;
    public int score;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    internal void GetScore(int value) {
        score += value;
        ICommand updateScore = new UpdateScore(score);

        SendCommand(updateScore);
    }

    public void ReceiveCommand(ICommand command) {

    }

    public void SendCommand(ICommand command) {
        mediator.SendCommand(command, this);
    }
}
