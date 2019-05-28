using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour {

	void OnMouseDown()
	{
		SceneManager.LoadScene ("main");
	}

	void Update()
	{
		if (Input.GetKey ("escape")) 
		{
			SceneManager.LoadScene ("main");
		}
	}
}
