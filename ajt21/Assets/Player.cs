using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 7.5f;
    public float JumpForce = 5; 

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse); 
        }
    }
}
