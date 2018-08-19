using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespooler : MonoBehaviour {

	// Use this for initialization
	public int num;
	public GameObject[] obs;
	List<GameObject> obspooled;
	void Start () {
		obspooled=new List<GameObject>();
		int j=0;
		for (int i = 0; i < num; i++) 
		{
			GameObject a = Instantiate (obs [j]);
			a.SetActive (false);
			j++;
			if (j == obs.Length) {

				j = 0;}

			obspooled.Add (a);
		}

	}
	
	// Update is called once per frame


	public GameObject GetObstacles()
	{
		for (int i = 0; i < obspooled.Count; i++) {

			if (!obspooled [i].activeInHierarchy) {

				obspooled [i].SetActive (true);
				return obspooled [i];
			}

		}
		GameObject o=Instantiate (obs[Random.Range(0,obs.Length)]);
		return o;
	}

}
