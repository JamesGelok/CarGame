using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        InputHandling();
	}

    private void InputHandling() {
        // GO FORWARD
        if (Input.GetKey(KeyCode.W)) {
            rigidBody.AddRelativeForce(Vector3.forward);
        }
        // GO ANTIFORWARD (aka backwards)
        if (Input.GetKey(KeyCode.S)) {
            rigidBody.AddRelativeForce(-Vector3.forward);
        }

        // Turn Left
        if (Input.GetKey(KeyCode.A)) {
            rigidBody.transform.Rotate(Vector3.down);
        }

        // Turn Right
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.transform.Rotate(Vector3.up);
        }

        // JUMP
        if (Input.GetKey(KeyCode.Space)) {
            rigidBody.AddForce(Vector3.up);
        }


    }
}
