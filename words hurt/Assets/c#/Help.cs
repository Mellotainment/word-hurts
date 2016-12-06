using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour {


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("h")) {

			SceneManager.LoadScene (3);
		}
	}
}