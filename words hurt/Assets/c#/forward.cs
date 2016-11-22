using UnityEngine;
using System.Collections;

public class forward : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(1,0,0), 0.2f);
	}
}
