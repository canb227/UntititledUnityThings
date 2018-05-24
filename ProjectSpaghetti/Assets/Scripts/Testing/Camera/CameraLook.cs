using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {
	public int verticalRotateMod;
	public double upperViewingBound, lowerViewingBound;//Upper bound should be positive and lower bound should be negative, .7588 is roughly straight up and -.7588 is straight down

	void Update () {
		if (transform.localRotation.x < upperViewingBound && transform.localRotation.x > lowerViewingBound) {
			transform.Rotate (new Vector3 (-Input.GetAxis ("Mouse Y"), 0, 0) * verticalRotateMod * Time.deltaTime);
		}
		if (transform.localRotation.x > upperViewingBound) {
			transform.Rotate (new Vector3 ((float)50, 0, 0) * Time.deltaTime);
		}
		if (transform.localRotation.x < lowerViewingBound) {
			transform.Rotate (new Vector3 ((float)-50, 0, 0) * Time.deltaTime);
		}

	}
}
