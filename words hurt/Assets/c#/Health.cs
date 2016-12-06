using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	//N3k N3k En help with this code(https://www.youtube.com/watch?v=9W0xLonwbLo&t=662s)


	public bool isDamaging;
	public float damage = 10;

	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player")
			col.SendMessage((isDamaging)?"TakeDamage" : "HealDamage", Time.deltaTime * damage);
	}
}
