using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBubble : MonoBehaviour {

	//[SerializeField]
	public static float fallSpeed = 3f;
	public static bool bomb = false;

	void Update () 
	{
		if (transform.position.y < -6f) 
		{
			LifeChange.LifeDec ();
			Destroy (gameObject);
		}
		if (fallSpeed <= 0.1)
			fallSpeed = 0.1f;
		transform.position -= new Vector3 (0,fallSpeed*Time.deltaTime, 0);
		if (Input.GetKey ("escape")) 
		{
			SceneManager.LoadScene ("main");
			//Lose
		}
		if (bomb) {
			ScoreChange.ScoreUP ();
			Destroy (gameObject);
		}
	}

	void OnMouseDown()
	{
		//GameObject.Find("AudioBulk").GetComponent <AudioSource>().Play();
		ScoreChange.ScoreUP ();
		Destroy (gameObject);
		//GetComponent <AudioSource> ().Play ();
	}

	//public static void Bomb()
	//{
	//	ScoreChange.ScoreUP ();
	//}
}
