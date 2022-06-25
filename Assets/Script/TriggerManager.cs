using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class TriggerManager : MonoBehaviour
{
    public GameObject Gawang1, Gawang2, Gawang3, Gawang4;

    bool player1 = true, player2 = true, player3 = true, player4 = true;

    public int playerCounter;

    private void Update()
    {
        if (playerCounter == 3)
        {
            if (player1)
            {
                Debug.Log("P1 Win");
                SceneManager.LoadScene("Game Over");
                WinnerVar.Winner = "Player 1 Menang!";
            }
            if (player2)
            {
                Debug.Log("P2 Win");
                SceneManager.LoadScene("Game Over");
                WinnerVar.Winner = "Player 1 Menang!";
            }
            if (player3)
            {
                Debug.Log("P3 Win");
                SceneManager.LoadScene("Game Over");
                WinnerVar.Winner = "Player 1 Menang!";
            }
            if (player4)
            {
                Debug.Log("P4 Win");
                SceneManager.LoadScene("Game Over");
                WinnerVar.Winner = "Player 1 Menang!";
            }
        }
    }

    public void gawangActive1()
    {
        Gawang1.GetComponent<MeshRenderer>().enabled = true;
        Gawang1.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
       player1 = false;
    }

    public void gawangActive2()
    {
        Gawang2.GetComponent<MeshRenderer>().enabled = true;
        Gawang2.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        player2 = false;
    }

    public void gawangActive3()
    {
        Gawang3.GetComponent<MeshRenderer>().enabled = true;
        Gawang3.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        player3 = false;
    }

    public void gawangActive4()
    {
        Gawang4.GetComponent<MeshRenderer>().enabled = true;
        Gawang4.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        player4 = false;
    }
}
