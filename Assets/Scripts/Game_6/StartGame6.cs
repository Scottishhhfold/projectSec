using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame6 : MonoBehaviour {


	public static bool start = false;

	void OnMouseUpAsButton()
	{
		start = true;
		Game6.cl = true;
	}
}