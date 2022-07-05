using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager
{
    public void SendCommand(ICommand command);
    public void ReceiveCommand(ICommand command);
}
