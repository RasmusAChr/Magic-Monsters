using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LINK TIL VIDEO
// https://www.youtube.com/watch?v=LNLVOjbrQj4

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;

    void Update()
    {
        // Tjekker for horisontale og vertikale inputs.
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Sætter 'Speed' i Animator parameteren til den numeriske sum af movement.x og movement.y.
        animator.SetFloat("Speed", (Mathf.Abs(movement.x) + Mathf.Abs(movement.y)));

        // Normaliser movement vektoren, så man ikke går 40% hurtigere diagonalt.
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        // Rykker spillerens position
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // Hvis venstre piletast er trykket ned, så skal spilleren dreje til venstre.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.rotation += 6.0f;
        }
        // Hvis højre piletast er trykket ned, så skal spilleren dreje til højre.
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.rotation -= 6.0f;
        }
    }
}
