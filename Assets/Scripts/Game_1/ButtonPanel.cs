using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour {

	public Sprite layer_one, layer_to;
	public static string NameButton;
	public static bool Activ = false;

	void OnMouseDown ()
	{
		GetComponent <SpriteRenderer> ().sprite = layer_to;
	}

	void OnMouseUp ()
	{
		GetComponent <SpriteRenderer> ().sprite = layer_one;
	}

	/*void Update ()
	{
		if (gameObject.name == NameButton && Activ == true)
			GetComponent <SpriteRenderer> ().sprite = layer_to;
		else
			GetComponent <SpriteRenderer> ().sprite = layer_one;
	}*/
	
}
