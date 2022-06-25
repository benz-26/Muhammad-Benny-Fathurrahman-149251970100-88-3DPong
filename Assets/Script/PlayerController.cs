using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rig;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private int speed;
    public bool player1, player2, player3, player4;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        //panggil component rigibody dulu saat start
        rig = GetComponent<Rigidbody>();
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(rightKey))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(leftKey))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    public void destroyPlayer()
    {
        if (player1)
        {
            gameObject.SetActive(false);

        }
        if (player2)
        {
            gameObject.SetActive(false);
        }
        if (player3)
        {
            gameObject.SetActive(false);
        }
        if (player4)
        {
            gameObject.SetActive(false);
        }
    }
}