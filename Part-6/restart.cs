using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	// Use this for initialization
	public void onRestartPress()
	{
		SceneManager.LoadScene ("game");

	}
	

}
