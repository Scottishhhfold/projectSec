using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Msc : MonoBehaviour {
	public Text scoretxt;
	public static int Mscore = 0;
	void Start () {
		Mscore=PlayerPrefs.GetInt ("MscoreG2");
	}

	void Update () {
		scoretxt.text = Mscore.ToString ();
	}
}
