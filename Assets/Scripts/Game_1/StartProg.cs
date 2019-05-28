using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartProg : MonoBehaviour {

	//private int n = 0;
	public static int Life = 0;
	public static int TLife = 0;
	public static int Money = 0;
	public static int Bomb = 0;
	public static int X2Money = 0;
	public static int Frozi = 0;
	public static int MaxScore = 0;
	//public static string First = "yes";
	void Start () {
			Life = PlayerPrefs.GetInt ("Life");
		if (Life < 3)
			Life = 3;
			TLife = PlayerPrefs.GetInt ("TLife");
			Money = PlayerPrefs.GetInt ("Money");
			Bomb = PlayerPrefs.GetInt ("Bomb");
			X2Money = PlayerPrefs.GetInt ("X2Money");
			Frozi = PlayerPrefs.GetInt ("Frozi");
			MaxScore = PlayerPrefs.GetInt ("MaxScore");
	}

	public static void ReStore()
	{
		PlayerPrefs.SetInt ("Life", Life);
		PlayerPrefs.SetInt ("TLife", TLife);
		PlayerPrefs.SetInt ("Money", Money);
		PlayerPrefs.SetInt ("Bomb", Bomb);
		PlayerPrefs.SetInt ("X2Money", X2Money);
		PlayerPrefs.SetInt ("Frozi", Frozi);
		PlayerPrefs.SetInt ("MaxScore", MaxScore);
	}
}