using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMediator
{
    public void AddManager(IManager manager);
    public void SendCommand(ICommand command, IManager sender);
}
