using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour {

	void OnMouseUp()
	{
		StartProg.Money += 10000;
		StartProg.ReStore ();
	}
}
