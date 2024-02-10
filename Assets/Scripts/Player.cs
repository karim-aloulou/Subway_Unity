using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    public float speed = 200f;
    public enum PlayerPosition { Left, Center, Right };
    public PlayerPosition currentPosition = PlayerPosition.Center;

    void Update()
    {
        rb.velocity = new Vector3(0, 0, 3);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentPosition == PlayerPosition.Left)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                currentPosition = PlayerPosition.Center;
            }
            else if (currentPosition == PlayerPosition.Center)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                currentPosition = PlayerPosition.Right;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentPosition == PlayerPosition.Right)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                currentPosition = PlayerPosition.Center;
            }
            else if (currentPosition == PlayerPosition.Center)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                currentPosition = PlayerPosition.Left;
            }
        }
    }
}
