using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// LINK TIL VIDEO
// https://www.youtube.com/watch?v=LNLVOjbrQj4

public class PlayerMovement : MonoBehaviourPun
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {/*
        if (photonView.IsMine)
        {
            photonView.RPC("GameManager.SpawnPlayer", RpcTarget.AllBuffered, null);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            // Normalize the movement vector is to avoid making diagonal movement faster by a factor of approximately 40%
            // When you move diagonally without a normalized vector (which has a magnitude of 1), you get a vector with a magnitude of the square root of 2, which is approximately 1.4
            movement = movement.normalized;

            //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void FixedUpdate(){
        if (photonView.IsMine)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.rotation += 6.0f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.rotation -= 6.0f;
            }

            //Vector2 lookDir = mousePos - rb.position;
            //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            //rb.rotation = angle;
        }
    }
}
