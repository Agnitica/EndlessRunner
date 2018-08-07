using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour {

	// Use this for initialization
	public int num;
	public GameObject[] plats;
	List<GameObject> pooled;


	void Start () {
		
		pooled=new List<GameObject>();
		int j=0;
		for (int i = 0; i < num; i++) 
		{
			GameObject a = Instantiate (plats [j]);
			a.SetActive (false);
			j++;
			if (j == plats.Length) {
					
				j = 0;}

			pooled.Add (a);
		}

	}
public GameObject GetPlaform()
	{
		for (int i = 0; i < pooled.Count; i++) {
		
			if (!pooled [i].activeInHierarchy) {
			
				pooled [i].SetActive (true);
				return pooled [i];
			}
		
		}
		return null;
	}


	
	// Update is called once per frame


}
