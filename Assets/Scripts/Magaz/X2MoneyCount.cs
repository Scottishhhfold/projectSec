using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X2MoneyCount : MonoBehaviour {

	void Update () {
		gameObject.GetComponent<Text> ().text = StartProg.X2Money.ToString ();
	}
}
