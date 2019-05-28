using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour {

	public Sprite layer_one, layer_to;

	void OnMouseDown ()
	{
		GetComponent <SpriteRenderer> ().sprite = layer_to;
	}

	void OnMouseUp ()
	{
		GetComponent <SpriteRenderer> ().sprite = layer_one;
	}

	void OnMouseUpAsButton()
	{
		//GameObject.Find("Click").GetComponents <AudioSource>
		//GameObject.Find("Click").GetComponent <AudioSource>().Play();
		switch (gameObject.name) {
		case "Game_1":
			//SceneManager.LoadScene(
			SceneManager.LoadScene("Game_1");
			//Application.LoadLevel ("Game_1");
			break;
		case "Game_2":
			SceneManager.LoadScene("Game_2");
			break;
		case "Game_3":
			SceneManager.LoadScene("Game_3");
			break;
		case "Game_4":
			SceneManager.LoadScene("Game_4");
			break;
		case "Game_5":
			SceneManager.LoadScene("Game_5");
			break;
		case "Game_6":
			SceneManager.LoadScene("Game_6");
			break;
		case "Setings":
			SceneManager.LoadScene("Setings");
			break;
		case "Help":
			SceneManager.LoadScene("Help");
			break;
		case "Exit":
			Application.Quit ();
			break;
		case "Magaz":
			SceneManager.LoadScene("Magaz");
			break;
		case "BackMagaz":
			SceneManager.LoadScene("Magaz");
			break;
		case "BackGame":
			SceneManager.LoadScene("Game_1");
			break;
		case "Home":
			SceneManager.LoadScene("main");
			break;
		case "Music":
			//SceneManager.LoadScene("main");



			break;
		case "Back":
			StartGame4.start = false;
			Game4.blb = true;
			SpawnLight.lose = true;
			SpawnLight.next = true;
			StartGame.start = false;
			SceneManager.LoadScene("main");
			break;
		}	

	}
}