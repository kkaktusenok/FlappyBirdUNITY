using System;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public logicScript logic;

    private void Start()
    { 
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
