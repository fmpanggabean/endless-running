using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : ICommand
{
    public int score { get; set; }

    public UpdateScore(int value) {
        score = value;
    }
}
