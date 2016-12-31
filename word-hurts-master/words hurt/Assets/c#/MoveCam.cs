using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = new Vector3 (-2, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
