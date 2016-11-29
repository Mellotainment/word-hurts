using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public bool isDamaging;
	public float damage = 10;

	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player")
			col.SendMessage((isDamaging)?"TakeDamage" : "HealDamage", Time.deltaTime * damage);
	}
}
