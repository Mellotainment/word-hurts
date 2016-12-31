using UnityEngine;
using System.Collections;

public class words : MonoBehaviour {


	public AudioClip YouStink;  
		 
	void Start ()
	{
		
	}

	void OnTriggerEnter ()  
	{
		GetComponent<AudioSource> ().clip = YouStink;
		      
		GetComponent<AudioSource> ().Play ();

	}
	//monster moving forward
	void Update(){
		//monster moving forward
		transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(1,0,0), 0.2f);
	}
}