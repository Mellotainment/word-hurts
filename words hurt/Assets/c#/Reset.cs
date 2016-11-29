using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

string WordsHurt;


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("r")) {

			SceneManager.LoadScene (0);
		}
	}
}

	