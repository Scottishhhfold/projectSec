using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour {

	void Update () {
		gameObject.GetComponent<Text> ().text = StartProg.Money.ToString ();
	}
}
