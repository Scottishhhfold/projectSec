using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddItem : MonoBehaviour {
	private int n = 0;
	//public static int life = 3;

	void OnMouseUpAsButton()
	{
		switch (gameObject.name) {
		case "Bomb":
			n = StartProg.Money;
			if (n >= 200) {
				StartProg.Bomb++;
				n -= 200;
				StartProg.Money = n;
				StartProg.ReStore ();
			}
			break;

		case "X2Money":
			n = StartProg.Money;
			if (n >= 100) {
				StartProg.X2Money++;
				n -= 100;
				StartProg.Money = n;
				StartProg.ReStore ();
			}
			break;

		case "Frozi":
			n = StartProg.Money;
			if (n >= 50) {
				StartProg.Frozi++;
				n -= 50;
				StartProg.Money = n;
				StartProg.ReStore ();
			}
			break;

		case "Heart":
			n = StartProg.Money;
			if ((n >= 150 )) 
			{
					StartProg.Life++;
					StartProg.TLife = StartProg.Life;
					n -= 150;
					StartProg.Money = n;
					StartProg.ReStore ();
			}
			break;

		case "Fon":
			SceneManager.LoadScene ("MagazFon");
			break;

		case "Fon1":
			Fon.NFon = 0;
			break;

		case "Fon2":
			Fon.NFon = 1;
			break;
		}

	}
}
