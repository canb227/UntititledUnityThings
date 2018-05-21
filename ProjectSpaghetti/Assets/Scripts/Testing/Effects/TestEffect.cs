using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEffect :  MonoBehaviour, Effect {
	public string ID(){return "TestEffect";}
	public void Play()
	{
		Instantiate(gameObject, transform.position + Vector3.up, transform.rotation);
	}
}
