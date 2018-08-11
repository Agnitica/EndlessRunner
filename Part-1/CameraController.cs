using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public PlayerController player; 
	private float z;

	void Start () {
		z= player.transform.position.z-transform.position.z; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x , transform.position.y, player.transform.position.z-z);
	}
}
