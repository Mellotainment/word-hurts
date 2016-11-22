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
}