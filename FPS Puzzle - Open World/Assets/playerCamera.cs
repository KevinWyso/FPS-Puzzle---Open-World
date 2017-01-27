using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {

	//Gameobject to follow
	public Transform player;

	private Transform camera;

	// Use this for initialization
	void Start () {
		camera = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		camera.LookAt (player);
	}
}
