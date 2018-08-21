using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforgeneration : MonoBehaviour {

	public GameObject[] p;
	public GameObject Player;
	private Vector3 d;
	public Pooler pool;
	public float maxh;
	public float minh;
	public float mind;
	public float maxd;
	public obstaclespooler obs;
	//public float minv;
	//public float maxv;

	// Use this for initialization
	void Start () {

		d =   transform.position-Player.transform.position;


	}

	// Update is called once per frame
	void Update () {
		if (transform.position.z - Player.transform.position.z < d.z)
		{
			//GameObject pt = Instantiate (p[Random.Range (0, p.Length)]);

			float temph = Random.Range (minh, maxh);
		//	if (temph < 0) {
				float tempd = Random.Range (mind, maxd);
		//	}
		//s	float tempv = Random.Range (minv, maxv);
			GameObject pt=pool.GetPlaform();
			pt.transform.position = new Vector3 (transform.position.x, transform.position.y+temph, transform.position.z+pt.GetComponentInChildren<Collider> ().bounds.size.z+tempd);
			GameObject ob = obs.GetObstacles ();
			int num = Random.Range (0, 3);
			float zmax = pt.transform.position.z;
			float zmin = zmax - pt.GetComponentInChildren<Collider> ().bounds.size.z;
			float xmax = pt.transform.position.x+pt.GetComponentInChildren<Collider> ().bounds.size.x/2;
			float xmin = xmax - pt.GetComponentInChildren<Collider> ().bounds.size.x;
			float z = Random.Range (zmin+ob.GetComponentInChildren<Collider> ().bounds.size.z/2, zmax-ob.GetComponentInChildren<Collider> ().bounds.size.z/2);
			float x = Random.Range (xmin+ob.GetComponentInChildren<Collider> ().bounds.size.x/2, xmax-ob.GetComponentInChildren<Collider> ().bounds.size.x/2);
			ob.transform.position = new Vector3 (x, pt.transform.position.y, z);
			//float x2 = pt.transform.position.z-pt.GetComponentInChildren<Collider> ().bounds.size.z;
			//Random.Range(x1- pt.transform.position.z-pt.GetComponentInChildren<Collider> ().bounds.size.z,x1);


			transform.position = new Vector3(pt.transform.position.x,pt.transform.position.y,pt.transform.position.z);
		}

	}
}
