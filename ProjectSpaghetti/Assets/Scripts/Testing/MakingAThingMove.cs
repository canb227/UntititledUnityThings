using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingAThingMove : MonoBehaviour {

	public int upForceMod;
	Rigidbody rb; //Storing the objects own rigidbody

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * upForceMod); //Adding upwards force while button is pressed down
		}
	}
}
