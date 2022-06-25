using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private int maxPowerUpAmount = 3;
    public int spamInterval;
    private List<GameObject> ballList;
    public GameObject ball;

    private float timer;

    void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        GenearateBall();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spamInterval)
        {
            GenearateBall();
            timer -= spamInterval;
        }
    }

    public void GenearateBall()
    {
        int spawnPos = Random.Range(1, 5);
        if (spawnPos == 1)
        {
            //Pojok Kiri Bawah
            GenearateBallPost(1);
        }
        else if (spawnPos == 2)
        {
            //Pojok Kiri Atas
            GenearateBallPost(2);
        }
        else if (spawnPos == 3)
        {
            //Pojok Kanan Atas
            GenearateBallPost(3);
        }
        else if (spawnPos == 4)
        {
            //Pojok Kanan Bawah
            GenearateBallPost(4);
        }
    }

    public void GenearateBallPost(int spawnPoints)
    {
        Vector3 speedSpawned;
        Vector3 spawnPos;
        if (ballList.Count >= maxPowerUpAmount)
        {
            return;
        }
        if (spawnPoints == 1)
        {
            speedSpawned = new Vector3(200, 0, 500);
            spawnPos = new Vector3(-7, 2, -17);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 2)
        {
            speedSpawned = new Vector3(1000, 0, -300);
            spawnPos = new Vector3(-7, 2, -17);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 3)
        {
            speedSpawned = new Vector3(-200, 0, -500);
            spawnPos = new Vector3(-7, 2, -17);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 4)
        {
            speedSpawned = new Vector3(-1000, 0, 300);
            spawnPos = new Vector3(-7, 2, -17);
            SpawnBall(speedSpawned, spawnPos);
        }
        Debug.Log(ballList.Count);
    }

    private void SpawnBall(Vector3 speedSpawned, Vector3 spawnPos)
    {
        GameObject ballSpawned = Instantiate(ball, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        ballSpawned.GetComponent<BallController>().speed = speedSpawned;
        ballSpawned.SetActive(true);
        ballList.Add(ballSpawned);
    }

    public void RemoveBall(GameObject ballObject)
    {
        ballList.Remove(ballObject);
        Destroy(ballObject);
    }
}
