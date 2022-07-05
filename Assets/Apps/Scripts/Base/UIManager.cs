using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour, IManager {
    public static UIManager instance;
    public IMediator mediator;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    public void ReceiveCommand(ICommand command) {
        Debug.Log(command);
    }

    public void SendCommand(ICommand command) {

    }
}
