using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterTest : MonoBehaviour {

	public int moveSpeed;
	public int jumpForce;
	public int rotateSpeed;

	private Animator animControl;
	private Rigidbody rb;

	private Vector3 lastPos;
	void Start()
	{
		animControl = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		lastPos = transform.position;
	}
	void Update () {
		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * jumpForce * 10);
			animControl.SetBool("Jump", true);
		}

		transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed, 0));
	}

	void FixedUpdate()
	{
		animControl.SetFloat("HorizontalV", 50 * Vector3.Distance(transform.position,lastPos));
		//animControl.SetFloat("HorizontalV", 50 * (transform.position.z-lastPos.z));
		//animControl.SetFloat("VerticalV", 50 * (transform.position.y-lastPos.y));

		lastPos = transform.position;
	}

	void OnCollisionEnter(Collision c)
	{
		animControl.SetBool("Jump", false);
	}
}
