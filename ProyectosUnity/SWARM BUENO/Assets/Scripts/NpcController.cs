using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    private Animator npcAC;

    //Movement modifier applied to directional movement.
    public float playerSpeed = 4.0f;

    // What the current speed of our player is
    public float currentSpeed = 0.0f;
    
    // The last movement that we've made
    private Vector3 lastMovement = new Vector3();


    // Use this for initialization
    void Start () {
        npcAC = GetComponent<Animator>();
}

// Update is called once per frame
void Update () {        

        Movement();
	}

    void Movement()
    {
        // The movement that needs to occur this frame
        Vector3 movement = new Vector3();

        // Check for input
        movement.x += Input.GetAxis("Horizontal");
        movement.y += Input.GetAxis("Vertical");

        /*
		* If we pressed multiple buttons, make sure we're only
		* moving the same length.
		*/
        movement.Normalize();

        // Check if we pressed anything
        if (movement.magnitude > 0)
        {
            // If we did, move in that direction
            currentSpeed = playerSpeed;
            npcAC.SetFloat("Speed", currentSpeed);
            this.transform.Translate(movement * Time.deltaTime * playerSpeed, Space.World);
            lastMovement = movement;
        }
        else
        {
            // Otherwise, move in the direction we were going
            this.transform.Translate(lastMovement * Time.deltaTime *
        currentSpeed, Space.World);
            // Slow down over time
            currentSpeed *= .1f;
            npcAC.SetFloat("Speed", currentSpeed);

        }
    }
}
