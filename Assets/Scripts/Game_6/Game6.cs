using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game6 : MonoBehaviour {

	public static int Z = 0,V = 0,N = 0;
	public static float f = -5.7f,fk = 0.1f,hard = 0f;
	public static int score = 1,n = 0;
	public static bool blb = true,cl = false,lose=false,clic=false;
	public GameObject[] mc;
	public GameObject[] mkc;
	public GameObject line;
	public int k,z;
	public int[] m = new int[9];
	public static int[] clz = new int[3];
	public Text scoretxt;
	public static int[] rot = new int[4];
	public GameObject Panels;

	void Start () {
		for (int i = 0; i < 9; i++) {
			m [i] = 0;
		}
		clz [0] = -1;
		clz [1] = -1;
		clz [2] = -1;
		rot [0] = 90;
		rot [1] = 180;
		rot [2] = 270;
		rot [3] = 0;

	}

	void Update () {
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		scoretxt.text = score.ToString ();
		if (blb && StartGame6.start) {
			Panels.SetActive (false);
			//Debug.Log ("starting");
			//Debug.Log ("lenght: " + mc.Length);
			strbl ();
			blb = false;
			f = 0f;
		}

		if (lose) {
			del ();
			f = -5.66f;
			blb = true;
			Panels.SetActive (true);
			StartGame6.start = false;
			lose = false;
			hard = 0;
			PlayerPrefs.SetInt("MscoreG6",score);
			score = 0;
			clic = false;
		}

		if (f <= -5.66f && StartGame6.start) {
			lose = true;
		} else {
			f -= Time.deltaTime;
			line.transform.position = new Vector3 (f, -3.95f, 0);
		}
		if (clic) {
			if (V == N) {
				del ();
				if (fk <= 0) {
					score++;
					V = -1;
					N = -2;
					strbl ();
					clic = false;
					fk = 0.1f;
					hard -= 0.1f;
				} else {
					fk -= Time.deltaTime;
				}
				f = 0 + hard;
			} else {
				V = -1;
				N = -2;
				lose = true;
			}
		}
	}

	void strbl()
	{	
		cl = true;
		for (int i = 0; i < 9; i++) {
			m [i] = 0;
		}
		z = 8;
		k = 0;
		for (;;) {
			k = (int)Random.Range (0, 8);
			if (m [k] == 0) {
				m [k] = z;
				z--;
			}
			if (z == 0)
				break;
		}

		k = 0;

		for (float y = -0.5f; y <= 2.8f; y += 1.6f) {//ВИСОТА
			for (float i = -1.6f; i < 1.7f; i += 1.6f) {//ШИРИНА
				Instantiate (mc [m [k]], new Vector2 (i, y), Quaternion.identity);
				k++;
			}
		}
		V = (int)Random.Range (0, 8);
		Instantiate (mc [V], new Vector2 (0, -2.4f), Quaternion.identity);
	}

	void del()
	{
		mkc = GameObject.FindGameObjectsWithTag ("hidbl");
		for (int i = 0; i < mkc.Length; i++) {
			Destroy (mkc [i]);
		}
	}
}