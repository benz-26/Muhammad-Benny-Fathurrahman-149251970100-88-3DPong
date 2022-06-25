using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool player1, player2, player3, player4;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            if (player1)
            {
                manager.AddP1Score(1);
                Debug.Log("P1");
            }
            if (player2)
            {
                manager.AddP2Score(1);
            }
            if (player3)
            {
                manager.AddP3Score(1);
                Debug.Log("P3");
            }
            if (player4)
            {
                manager.AddP4Score(1);
            }
        }
    }
}
