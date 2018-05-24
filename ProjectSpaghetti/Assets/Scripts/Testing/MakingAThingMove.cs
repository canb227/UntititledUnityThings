using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingAThingMove : MonoBehaviour {
	public bool horizontalMouseRotation, verticalMouseRotation, lockZRotation, lockYRotation, lockXRotation, invertVerticalMouseLook;
	public int upForceMod, forwardForceMod, leftForceMod, rightForceMod, backwardForceMod, horizontalRotateMod, verticalRotateMod;
	Rigidbody rb; //Storing the objects own rigidbody

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * upForceMod * Time.deltaTime); //Adding upwards force while button is pressed down
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			if (!Input.GetKey (KeyCode.S)) 
			{
				transform.Translate (Vector3.forward * forwardForceMod * Time.deltaTime);
			}
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			if (!Input.GetKey (KeyCode.W)) 
			{
				transform.Translate (-Vector3.forward * backwardForceMod * Time.deltaTime);
			}
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			if (!Input.GetKey (KeyCode.A)) 
			{
				transform.Translate (Vector3.right * rightForceMod * Time.deltaTime);
			}
		}
		else if (Input.GetKey (KeyCode.A)) 
		{
			if (!Input.GetKey (KeyCode.D)) 
			{
				transform.Translate (Vector3.left * leftForceMod * Time.deltaTime);
			}
		}
		// if(Input.GetKey(KeyCode.R))
		// {
		// 	transform.Rotate(new Vector3(0,1,0) * rotateMod * Time.deltaTime);
		// }
		if (horizontalMouseRotation) 
		{
			transform.Rotate (new Vector3 (0, Input.GetAxis ("Mouse X"), 0) * horizontalRotateMod * Time.deltaTime);
		}
		if (verticalMouseRotation && !invertVerticalMouseLook) {
			transform.Rotate (new Vector3 (-Input.GetAxis ("Mouse Y"), 0, 0) * verticalRotateMod * Time.deltaTime);
		} else if(verticalMouseRotation) {
			transform.Rotate (new Vector3 (Input.GetAxis ("Mouse Y"), 0, 0) * verticalRotateMod * Time.deltaTime);
		}

		//Code for locking rotation based on booleans
		if (lockXRotation) {
			if (lockYRotation) {
				if (lockZRotation) {
					transform.eulerAngles = new Vector3 (0, 0, 0);
				} else {
					transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
				}	
			} else {
				transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, transform.eulerAngles.z);
			}	
		}
		if (lockYRotation) {
			if (lockXRotation) {
				if (lockZRotation) {
					transform.eulerAngles = new Vector3 (0, 0, 0);
				} else {
					transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
				}
			} else {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, 0, transform.eulerAngles.z);
			}
		}
		if (lockZRotation) {
			if (lockXRotation) {
				if (lockYRotation) {
					transform.eulerAngles = new Vector3 (0, 0, 0);
				} else {
					transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
				}
			} else {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0);
			}
		}
	}
}
