using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody player;
	public float movingspeed=5f;
	public float vspeed=5.0f;
	public float xspeed=2f;
	private bool jump;
	
	
	
	// Use this for initialization
	void Start () {
		player =GetComponent<Rigidbody> ();
		player.velocity = new Vector3 (0, 0, 0);
		
	}
	
	// Update is called once per frame
	void Update () {


		
		player.velocity = new Vector3 (player.velocity.x, player.velocity.y, movingspeed);
			


		if ((jump)&&(Input.GetKeyDown ("space"))) 
		{    
			player.velocity = new Vector3 (player.velocity.x, vspeed ,player.velocity.z);
			jump = false;
	    } 


		if (Input.GetKey("left")) {
			
			player.transform.position+=Vector3.left*xspeed*Time.deltaTime;
		
		}

		if (Input.GetKey("right")) {
			player.transform.position+=Vector3.right*xspeed*Time.deltaTime;
		
		}
		
	}


	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "terrain") {			
			jump = true;

		}
	}
	


}
