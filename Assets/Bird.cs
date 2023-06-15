using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float myFlyVelocity;
    public logicScript logic;
    public bool birdIsLive = true;
    
    private void Start()
    { 
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsLive)
        {
            MyRigidBody.velocity = Vector2.up * myFlyVelocity;   
        }

        if (transform.position.y > 5.05 || transform.position.y < -5.05)
        {
            logic.GameOver();
            birdIsLive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        logic.GameOver();
        birdIsLive = false;
    }
}