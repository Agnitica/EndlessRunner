using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Rigidbody player;
	public float movingspeed=5f;
	public float vspeed=5.0f;
	public float xspeed=2f;
	private bool jump;
	public Animator animator;
	private Vector3 playerPosition;
	private Quaternion playerrot;
	public int health = 5;
	public RectTransform gameOver;

	float ktimer=0;
	private float yposition;

	// Use this for initialization
	void Start () {


		player =GetComponent<Rigidbody> ();
		player.velocity = new Vector3 (0, 0, 0);
		playerPosition= animator.transform.localPosition;
		playerrot = animator.transform.rotation;
		gameOver.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (ktimer > 0) {
		
			player.velocity = new Vector3 (0, 0, 0);
			animator.SetFloat ("Velocity", player.velocity.z);
			gameOver.gameObject.SetActive (true);


		

		} else {
			player.velocity = new Vector3 (player.velocity.x, player.velocity.y, movingspeed);
			animator.SetFloat ("Velocity", player.velocity.z);
		
			if (player.transform.position.y < yposition - 40f) {
			
				ktimer = 1;
			}

			if ((jump) && (Input.GetKeyDown ("space"))) {    
				player.velocity = new Vector3 (player.velocity.x, vspeed, player.velocity.z);
				jump = false;
			} 


			if (Input.GetKey ("left")) {
				
				player.transform.position += Vector3.left * xspeed * Time.deltaTime;
				
			}

			if (Input.GetKey ("right")) {
				player.transform.position += Vector3.right * xspeed * Time.deltaTime;
				

			}
			
			animator.SetBool ("onPlatform", jump);
		}

	}



	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "terrain") {			
			jump = true;
			yposition = player.transform.position.y;

		}

		if (coll.gameObject.tag == "obstacles") 
		{

			ktimer = 1f;
		


			}
		



	}


	

	void LateUpdate () {
		
		animator.transform.localPosition =playerPosition;
		animator.transform.localRotation = playerrot;
	}


}
