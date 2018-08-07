using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	private float dist;

	public CameraController cam;
	// Use this for initialization
	void Start () {

		dist=cam.transform.position.z-transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {

		transform.position=new Vector3(transform.position.x,transform.position.y,cam.transform.position.z-dist);

		GameObject a=GameObject.FindGameObjectWithTag ("Platform");
		if (a != null) {


			if (a.transform.position.z< transform.position.z) {


				//Destroy (a);
				a.SetActive(false);
			
			}
		}


	}
}
