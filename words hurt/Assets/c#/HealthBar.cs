using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//N3k N3k En help with this code

public class HealthBar : MonoBehaviour {

	public float hitpoint = 150;
	public float maxHitpoint = 150;
	public Image currentHealthbar;
	public Text ratioText;

	private void Start()
	{
		UpdateHealthbar ();
	}

	private void UpdateHealthbar()
	{
		float ratio = hitpoint / maxHitpoint;
		currentHealthbar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString ("0") + '%';
	}
	private void TakeDamage(float damage)
	{
		hitpoint -= damage;
		if (hitpoint < 0) {
			hitpoint = 0;
			Debug.Log ("dead!");
		}
	
	UpdateHealthbar();
}

	private void HealDamage (float heal)
	{
		hitpoint += heal;
		if (hitpoint > maxHitpoint)
			hitpoint = maxHitpoint;
			Debug.Log ("heal");

		UpdateHealthbar();
	}

}