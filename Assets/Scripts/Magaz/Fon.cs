using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fon : MonoBehaviour {

	public Sprite[] fon;
	public static int NFon = 1;

	void Start () {
		GetComponent <SpriteRenderer> ().sprite = fon[NFon];
	}

	void Update () {
		GetComponent <SpriteRenderer> ().sprite = fon[NFon];
	}
}
