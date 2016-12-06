using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour {


	public float hitpoint = 150;
	public float maxHitpoint = 150;


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene (2);
	}
}