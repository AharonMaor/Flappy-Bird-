using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigibody;
    public float flaspStrength;
    public LogicScript logic;
    public bool birdIsAlive=true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per framed
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigibody.velocity = Vector2.up * flaspStrength;
        }

        if (transform.position.y > 13 || transform.position.y < -12)
          {
            defeat();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        defeat();
    }

    private void defeat()
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
