using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game4 : MonoBehaviour {

	public static int Z = 0;
	public static float f = 0f;
	public static int score = 0,life=1,n = 0;
	public static bool blb = true,cl = false,show=false;
	public GameObject[] mc;
	public int k,z;
	public int[] m = new int[16];
	public static int[] clz = new int[3];
	public Text scoretxt;
	public Text lifetxt;
	public static Color[] colors = new Color[8];
	public static Color[] col = new Color[3];

	void Start () {
		colors [0] = Color.black;
		colors [1] = Color.blue;
		colors [2] = Color.red;
		colors [3] = Color.cyan;
		colors [4] = Color.yellow;
		colors [5] = Color.green;
		colors [6] = Color.grey;
		colors [7] = Color.magenta;

		for (int i = 0; i < 16; i++) {
			m[i] = 0;
		}

		clz [0] = -1;
		clz [1] = -1;
		clz [2] = -1;
	}

	void Update () {
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		scoretxt.text = score.ToString ();
		lifetxt.text = life.ToString ();
		if (blb && StartGame4.start) {
			strbl ();
			blb = false;
			show = true;
		}
		if (show&&f>=400f) {
			show = false;
			f = 2f;
			mc = GameObject.FindGameObjectsWithTag ("hidbl");
			for (int i = 0; i < mc.Length; i++) {
				mc [i].GetComponent <SpriteRenderer> ().color = new Color32 (73, 124, 193, 255);
			}
		}
		if (Z == 2) {
			cl = false;
			if (f <= 0) {
				mc = GameObject.FindGameObjectsWithTag ("hidbl");
				for (int i = 0; i < mc.Length; i++) {
					mc [i].GetComponent <SpriteRenderer> ().color = new Color32 (73, 124, 193, 255);
				}
				cl = true;
				clz [1] = -1;
				clz [2] = -1;
				Z = 0;
				life--;
			} else {
				f -= Time.deltaTime;
			}
		}
		if (score % 16 == 0) {
			blb = true;
			SceneManager.LoadScene ("Game_4");
			n++;
			score++;
		}
		if (life == 0) {
			//Application.LoadLevel ("Game_4");
			blb = true;
			SceneManager.LoadScene ("Game_4");
		}
	}

	void strbl()
	{	
		for (int i = 0; i < 16; i++) {
			m[i] = 0;
		}
		life += 20-n;	
		z = 15;
		k = 0;
		for (;;) {
			k = (int)Random.Range (0, 15);
			if (m [k] == 0) {
				if (z >= 8)
					m [k] = z - 8;
				else
					m [k] = z;
				z--;
			}
			if (z == 0)
				break;
		}
		k = 0;
		for (float y = -2.5f; y <= 2.8f; y += 1.55f) {
			for (float i = -1.9f; i < 1.9f; i += 1.25f) {
				Instantiate (mc[m[k]], new Vector2 (i, y), Quaternion.identity);k++;
			}
		}
	}
}