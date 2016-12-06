using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {


		public void Test()
		{
			Debug.LogError("Button was pressed");
		SceneManager.LoadScene (0);
		}

	}
