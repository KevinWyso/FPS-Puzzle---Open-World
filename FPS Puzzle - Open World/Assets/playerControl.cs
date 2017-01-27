using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

	private Transform player;


	// Use this for initialization
	void Start () {
		//Get the player transform
		player = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			player.Translate (Vector3.forward * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S)) {
			player.Translate (Vector3.back * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.A)) {
			player.Translate (Vector3.left * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.D)) {
			player.Translate (Vector3.right * Time.deltaTime);
		}

	}
}
