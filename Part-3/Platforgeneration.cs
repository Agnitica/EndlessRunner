using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforgeneration : MonoBehaviour {

	public GameObject[] p;
	public GameObject Player;
	private Vector3 d;
	public Pooler pool;



	// Use this for initialization
	void Start () {

		d =   transform.position-Player.transform.position;


	}

	// Update is called once per frame
	void Update () {
		if (transform.position.z - Player.transform.position.z < d.z)
		{
			//GameObject pt = Instantiate (p[Random.Range (0, p.Length)]);
			GameObject pt=pool.GetPlaform();
			pt.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z+pt.GetComponentInChildren<Collider> ().bounds.size.z);
			transform.position = new Vector3(transform.position.x,pt.transform.position.y,transform.position.z+pt.GetComponentInChildren<Collider> ().bounds.size.z);
		}

	}
}
