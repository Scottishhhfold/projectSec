using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stgm3 : MonoBehaviour {

	public static int Nml = 1;
	public GameObject ml,bl;
	public Sprite ml1,ml2,ml3,ml4;
	public static bool blb = true;

	void Update () {
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		if (blb) {
			strbl ();
			blb = false;
		}
		mll ();
	}

	void mll()
	{
		switch (Nml) {
		case 1:
			ml.GetComponent <SpriteRenderer> ().sprite = ml1;
			break;
		case 2:
			ml.GetComponent <SpriteRenderer> ().sprite = ml2;
			break;
		case 3:
			ml.GetComponent <SpriteRenderer> ().sprite = ml3;
			break;
		case 4:
			ml.GetComponent <SpriteRenderer> ().sprite = ml4;
			break;
		}
	}

	void strbl()
	{
		//if (!GameObject.FindGameObjectWithTag ("hidbl")) {
			for (float y = -2.76f; y <= 3.3f; y += 1.2f) {
				for (float i = -1.8f; i < 1.9f; i += 1.2f) {
					Instantiate (bl, new Vector2 (i, y), Quaternion.identity);
				}
			}
		//}
	}
}