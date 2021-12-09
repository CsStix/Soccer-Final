using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;


        void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

      void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal1");
        vertical = Input.GetAxisRaw("Vertical1");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

}
