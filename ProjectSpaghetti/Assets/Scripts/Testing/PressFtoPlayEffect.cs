using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressFtoPlayEffect : MonoBehaviour {

	public GameObject TheEffectObject;
	public Effect TheEffect;

	void Start()
	{
		TheEffect = TheEffectObject.GetComponent<Effect>();
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.F))TheEffect.Play();
	}
}
