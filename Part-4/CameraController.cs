using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public PlayerController player; 
	
	private float z;
	private float y;
	
	void Start () {
		z=player.transform.position.z-transform.position.z;
		y=player.transform.position.y-transform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x,player.transform.position.y-y,player.transform.position.z-z);
		
	
	}
}
