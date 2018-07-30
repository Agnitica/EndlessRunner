using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody player;
	public float movingspeed=5f;
	public float vspeed=5.0f;
	// Use this for initialization
	void Start () {

		player =GetComponent<Rigidbody> ();
		player.velocity = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) 
		{
		
			player.velocity = new Vector3 (player.velocity.x, player.velocity.y, movingspeed);

		}
		if (Input.GetKeyDown ("space")) 
		{    
			player.velocity = new Vector3 (player.velocity.x, vspeed ,player.velocity.z);
	    } 
	}
}
