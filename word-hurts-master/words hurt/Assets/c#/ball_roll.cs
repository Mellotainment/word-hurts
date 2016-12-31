using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_roll : MonoBehaviour {

	public KeyCode MoveR;
	public KeyCode MoveL;

	public float horizVel = 0; 
	public int laneRun = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		GetComponent<Rigidbody> ().velocity = new Vector3 (horizVel, 0, 4);

		if((Input.GetKeyDown (MoveL))&&(laneRun>1))
		{
			horizVel = -2;
			StartCoroutine (stopSlide ());
			laneRun -= 1;
		}
		if((Input.GetKeyDown (MoveL))&&(laneRun>1))
		{
			horizVel = 2;
			StartCoroutine (stopSlide ());
			laneRun += 1;
		}
	}

	IEnumerator stopSlide()
	{
		yield return new WaitForSeconds (.5f);
		horizVel = 0;
	}
}

