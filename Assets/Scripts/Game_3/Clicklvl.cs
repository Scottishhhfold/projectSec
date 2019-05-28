using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicklvl : MonoBehaviour {

	public GameObject panel;
	float f = 0f;
	public bool m1 = false;
	public static int[] m = new int[5];
	public static int n = 1;


	void Start () {
		panel.GetComponent <SpriteRenderer> ().color = new Color32 (125, 78, 162, 255);
		stgm3.Nml = 1;
		n = 1;
		m [1] = 1;
		m [2] = 0;
		m [3] = 0;
		m [4] = 0;
	}

	void OnMouseUpAsButton()
	{
		f = 0.001f;
		m1 = true;
		switch (gameObject.name) {
		case "mal_1":
			panel.GetComponent <SpriteRenderer> ().color = new Color32 (125, 78, 162, 255);
			stgm3.Nml = 1;
			n = 1;
			break;
		case "mal_2":
			panel.GetComponent <SpriteRenderer> ().color = new Color32 (71, 153, 79, 255);
			stgm3.Nml = 2;
			n = 2;
			break;
		case "mal_3":
			panel.GetComponent <SpriteRenderer> ().color = new Color32 (223, 141, 44, 255);
			stgm3.Nml = 3;
			n = 3;
			break;
		case "mal_4":
			panel.GetComponent <SpriteRenderer> ().color = new Color32 (203, 71, 54, 255);
			stgm3.Nml = 4;
			n = 4;
			break;
		}
	}

	void Update(){
		if (f <= 0 && m1 && m [n] != 1) {
			m1 = false;
			stgm3.blb = true;
			m [n] = 1;
		} else {
			f -= Time.deltaTime;
		}
	}
}