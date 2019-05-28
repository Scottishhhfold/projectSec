using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text> ().text = StartProg.Life.ToString ();
	}
}
