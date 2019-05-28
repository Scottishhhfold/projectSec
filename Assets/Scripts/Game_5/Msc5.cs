using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Msc5 : MonoBehaviour {
	public Text scoretxt;
	public static int Mscore = 0;
	void Update () {
		Mscore = PlayerPrefs.GetInt ("MscoreG5");
		scoretxt.text = Mscore.ToString ();
	}
}
