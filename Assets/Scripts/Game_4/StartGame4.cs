using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame4 : MonoBehaviour {

	public GameObject Panels;
	public static bool start = false;

	void OnMouseUpAsButton()
	{
		Panels.SetActive (false);
		start = true;
		Game4.cl = true;
		//SpawnLight.next = true;
	}
}