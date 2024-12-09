using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public float jump_force;

    Rigidbody2D body;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h_input = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(h_input*speed,body.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(Vector2.up*jump_force,ForceMode2D.Impulse);
        }
    }
}
