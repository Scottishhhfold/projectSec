using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Msc4 : MonoBehaviour {
	public Text scoretxt;
	public static int Mscore = 0;
	void Start () {
		Mscore=PlayerPrefs.GetInt ("MscoreG4");
	}

	void Update () {
		scoretxt.text = Mscore.ToString ();
	}
}
