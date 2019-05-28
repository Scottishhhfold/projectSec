using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPlus : MonoBehaviour {

	void Update () {
		transform.position -= new Vector3 (0,2*Time.deltaTime, 0);
	}
	void OnMouseDown()
	{
		StartProg.Money+=10;
		StartProg.ReStore ();
		Destroy (gameObject);
	}
}