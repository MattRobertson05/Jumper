using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    public Rigidbody2D myRigidBody;
	// Use this for initialization
	void Start ()
    {
        Debug.Log("This is Start!");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // TODO: move the character to the right!
            myRigidBody.velocity = new Vector2(5, myRigidBody.velocity.y);
        }
       // this is the syntax for printing to the console!
       // Debug.Log("Test!");
	}
}
