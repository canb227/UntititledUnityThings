using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingAThingMove : MonoBehaviour {

	public int upForceMod, forwardForceMod, rotateMod;
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
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * forwardForceMod * Time.deltaTime);
		}
		// if(Input.GetKey(KeyCode.R))
		// {
		// 	transform.Rotate(new Vector3(0,1,0) * rotateMod * Time.deltaTime);
		// }
		transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"),0) * rotateMod);
	}
}
