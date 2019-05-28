using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCount : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text> ().text = StartProg.Bomb.ToString ();
	}
}
