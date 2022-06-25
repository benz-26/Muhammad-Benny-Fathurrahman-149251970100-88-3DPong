using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rig;
    public Vector3 speed;
    [SerializeField] private float maxSpeed = 300f;
    public Vector3 resetPosition;
    public Collider gawang1, gawang2, gawang3, gawang4;
    public SpawnController manager;
    public ScoreManager managerScore;


    // Start is called before the first frame update

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Paddle" || other.gameObject.tag == "BallSpawner")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                Debug.Log("OK");
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider collison)
    {
        if (collison == gawang1)
        {
            managerScore.AddP1Score(1);
            manager.RemoveBall(gameObject);
        }
        if (collison == gawang2)
        {
            managerScore.AddP2Score(1);
            manager.RemoveBall(gameObject);
        }
        if (collison == gawang3)
        {
            managerScore.AddP3Score(1);
            manager.RemoveBall(gameObject);
        }
        if (collison == gawang4)
        {
            managerScore.AddP4Score(1);
            manager.RemoveBall(gameObject);
        }
    }
}

