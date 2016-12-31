using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour {


	void Awake () 
	{
		Debug.Log ("First Scene Loaded");	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene(1);
		}
	}
}