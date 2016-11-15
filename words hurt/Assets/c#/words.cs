using UnityEngine;
using System.Collections;

public class words : MonoBehaviour {


	public AudioClip YouStink;  
		 
	void Start ()   
	{
		
		GetComponent<AudioSource> ().clip = YouStink;
	}        

	void OnTriggerEnter ()  
	{
		GetComponent<AudioSource> ().Play ();
	}
}