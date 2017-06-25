using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			PlayerController.instance.Kill();
			Debug.Log ("Player is Dead");
		}
	}

}
