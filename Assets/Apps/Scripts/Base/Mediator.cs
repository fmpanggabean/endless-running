using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mediator: IMediator {
    public List<IManager> managers;

    public Mediator() {
        managers = new List<IManager>();
    }

    public void AddManager(IManager manager) {
        managers.Add(manager);
    }

    public void SendCommand(ICommand command, IManager sender) {
        foreach(IManager manager in managers) {
            if (manager != sender) {
                manager.ReceiveCommand(command);
            }
        }
    }
}
