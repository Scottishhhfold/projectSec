using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeChange : MonoBehaviour {

	public static bool lose = false;
	public GameObject restart;
	public static int life = StartProg.Life;
	private int n = 0;
	public Text Life;

	void Update () {
		if (life <= 0) {
			lose = true;
			Life.text = "0";
			restart.SetActive (true);
			
			n = ScoreChange.score;
			if (n > StartProg.MaxScore) 
			{
				StartProg.MaxScore = n;
			}

			if (StartProg.Life >= 7)
				StartProg.Life = 7;
			//LifeChange.life = StartProg.Life;

			StartProg.Money += n / 2;
			StartProg.ReStore ();
			ScoreChange.score = 0;

		} else {
			Life.text = life.ToString ();
			//gameObject.GetComponent<Text> ().text = life.ToString ();
		}
	}

	public static void LifeDec(){
		life--;
	}
}
