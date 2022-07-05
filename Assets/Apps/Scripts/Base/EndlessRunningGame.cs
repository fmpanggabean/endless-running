using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunningGame : MonoBehaviour
{
    public Mediator mediator;

    public GameManager gameManager;
    public UIManager uiManager;

    void Start()
    {
        mediator = new Mediator();

        mediator.AddManager(gameManager);
        mediator.AddManager(uiManager);

        gameManager.mediator = mediator;
        uiManager.mediator = mediator;
    }
}
