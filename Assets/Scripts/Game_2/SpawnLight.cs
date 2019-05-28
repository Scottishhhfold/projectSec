using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class SpawnLight : MonoBehaviour {

	public GameObject Panels;
	public GameObject[] bubble;
	public static bool lose = false,next = true, show = true,wait = false,m1=true;
	public Text scoretxt;
	public int n = 0,nx = 0,cll = 0;
	public static int score = 0,inc = -1,incz = 0,Cl = -1;
	public float f = 0f,ft = 0.5f,fl = 0.5f;
	public int[] mas;


	void Start(){
		mas = new int[100];
		rnd ();
		new_level ();
	}

	void rnd(){
		for (int i = 0; i < 99; i++) {
			mas [i] = (int)Random.Range (0,5.9f);
		}
	}

	void Update () {
		if (PlayerPrefs.GetInt ("Music") == 1) {
			GetComponent <AudioSource> ().Play ();
		}
		cll = Cl;
		scoretxt.text = score.ToString ();
		if (StartGame.start) {
			if (lose) {
				StartGame.start = false;
				losed ();
			}
			next = false;

			if (show) {
				if (wait) {
					wait = false;
					ft = fl * 2;
					gam (mas [inc]);
					if (inc >= score + 2) {
						show = false;
						incz = 0;
						n = score + 2;
					}
				}
			} else {
				if (Cl != -1) {
					if (mas [nx] == Cl && m1) {
						nx++;
						Cl = -1;
						m1 = false;
						if (nx > n) {
							inc = 0;
							incz = 0;
							nx = 0;
							score++;
							show = true;
						}
					}
					if (incz > nx) {
						lose = true;
						next = true;
					}
				}
			}
			if (ft <= 0) {
				if (!wait) {
					wait = true;
					inc++;
				}
			} else {
				ft -= Time.deltaTime;
			}
		}
	}

	void gam (int a)
	{
		switch (a) {
		case 0:
			n1.flag = true;
			n1.f = fl;
			break;
		case 1:
			n2.flag = true;
			n2.f = fl;
			break;
		case 2:
			n3.flag = true;
			n3.f = fl;
			break;
		case 3:
			n4.flag = true;
			n4.f = fl;
			break;
		case 4:
			n5.flag = true;
			n5.f = fl;
			break;
		case 5:
			n6.flag = true;
			n6.f = fl;
			break;
		}
	} 

	void new_level(){
		Instantiate (bubble [0], new Vector2 (0f, 1.8f), Quaternion.identity);
		Instantiate (bubble [1], new Vector2 (0f, -1.8f), Quaternion.identity);
		Instantiate (bubble [2], new Vector2 (-1.5f, 0.8f), Quaternion.identity);
		Instantiate (bubble [3], new Vector2 (-1.5f, -0.8f), Quaternion.identity);
		Instantiate (bubble [4], new Vector2 (1.5f, 0.8f), Quaternion.identity);
		Instantiate (bubble [5], new Vector2 (1.5f, -0.8f), Quaternion.identity);
	}

	void losed(){
		if (score > PlayerPrefs.GetInt ("MscoreG2"))
			PlayerPrefs.SetInt ("MscoreG2", score);

		lose = false;next = true;show = true;wait = false;m1=true;
		score = 0;inc = -1;incz = 0;Cl = -1;n = 0;nx = 0;cll = 0;ft = 0.5f;
		rnd ();
		SceneManager.LoadScene ("Game_2");
	}

	IEnumerator TimeSleep(float s){
		yield return new WaitForSeconds (s);
	}
}