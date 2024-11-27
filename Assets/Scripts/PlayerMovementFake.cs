using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementFake : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vectorMovement = new Vector2(rb.velocity.x, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vectorMovement.y += 10;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vectorMovement.x -= 10* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           vectorMovement.x += 10*Time.deltaTime;
        }
        rb.velocity = vectorMovement;
    }
}
