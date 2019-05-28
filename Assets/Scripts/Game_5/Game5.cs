using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game5 : MonoBehaviour {

	public static float f = 1f,hard = 0f;
	public int N = 1;
	public static int score = 0, n = 0, k = 0,r = 2,il=0,Z=-1;
	public static bool blb = true, show = false,showZap = false,banan=false,banandes=false,cl=false;
	public static bool flip1 = false, flip2 = false, flip3 = false, up0 = false, up1 = false, up2 = false, down0 = false, down1 = false, down2 = false;
	public GameObject[] mc;
	public GameObject gm;
	public int [] m = new int[100];
	public Text scoretxt;
	public GameObject Panels;
	public static bool click = false;

	void Start(){
		for (int i = 0; i < 100; i++) {
			m [i] = -1;
		}
		Instantiate (mc [0], new Vector2 (-1.8f, -1.4f), Quaternion.identity);
		Instantiate (mc [1], new Vector2 (0f, -1.4f), Quaternion.identity);
		Instantiate (mc [2], new Vector2 (1.8f, -1.4f), Quaternion.identity);
		Instantiate (mc [3], new Vector2 (0f, -1.4f), Quaternion.identity);
	}

	void Update () {
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		scoretxt.text = score.ToString ();
		//scoretxt.text = N.ToString();
		if (blb && StartGame5.start) {
			Panels.SetActive (false);
			blb = false;
			show = true;
			//flip3 = true;
		}
		if (show) {
			switch (N) {
			case 0:
				up0 = true;
				break;
			case 1:
				up1 = true;
				break;
			case 2:
				up2 = true;
				break;
			}
			if (f < 0) {
				f = 0.4f;
				zap ();
				show = false;
				showZap = true;
				il = 0;
			} else {
				f -= Time.deltaTime;
			}
		}
		if (showZap) {
			if (f < 0) {
				gm = GameObject.FindGameObjectWithTag ("nex");
				Destroy (gm);
				switch (m [il]) {
				case 0:
					flip1 = true;
					down2 = true;
					if (N == 0) {
						N = 1;
						break;
					}
					if (N == 1) {
						N = 0;
						break;
					}
					break;
				case 1:
					flip2 = true;
					down0 = true;
					if (N == 1) {
						N = 2;
						break;
					}
					if (N == 2) {
						N = 1;
						break;
					}
					break;
				case 2:
					flip3 = true;
					down1 = true;
					if (N == 2) {
						N = 0;
						break;
					}
					if (N == 0) {
						N = 2;
						break;
					}
					break;
				}
				if (m [il] == -1) {
					showZap = false;
					banan = true;
					down0 = true;
					down1 = true;
					down2 = true;
					il = 0;
				}
				il++;
				f = 1.1f;
			} else {
				f -= Time.deltaTime;
			}

		}
		if (banan) {
			switch (N) {
			case 0:
				Instantiate (mc [3], new Vector2 (-1.8f, -1.7f), Quaternion.identity);
				break;
			case 1:
				Instantiate (mc [3], new Vector2 (0f, -1.7f), Quaternion.identity);
				break;
			case 2:
				Instantiate (mc [3], new Vector2 (1.8f, -1.7f), Quaternion.identity);
				break;
			}
			banan = false;
			cl = true;
		}

		if (!banan && Z != -1) {
			if (Z == N) {
				score++;
				show = true;
				r += 2;
				Z = -1;
			} else {
				Z = -1;
				r = 2;
				blb = true; 
				show = false;
				showZap = false;
				banan = false;
				banandes = false;
				cl = false;
				StartGame5.start = false;
				PlayerPrefs.SetInt ("MscoreG5", score);
				score = 0;
				Panels.SetActive (true);
			}
		}
	}

	void zap()
	{
		for (int i = 0; i < r; i++) {
			m [i] = (int)Random.Range (0, 3);
		}
	}



































//	void Start () {
		
		/*for (int i = 0; i < 9; i++) {
			m [i] = 0;
		}
		clz [0] = -1;
		clz [1] = -1;
		clz [2] = -1;
		rot [0] = 90;
		rot [1] = 180;
		rot [2] = 270;
		rot [3] = 0;*/
	//}
/*
	void Update () {
		
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
	}*/
}