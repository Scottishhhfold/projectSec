using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ansmath : MonoBehaviour {

	public Text ans;
	public int a, b, k, cl,ls=3;
	public static int c, an = 4,next=0;
	public InputField ansc;
	public GameObject[] msc;
	public GameObject[] nxt;

	public void pr()
	{	
		int.TryParse (ansc.text, out c);	
		if (c == an) {
			msc = GameObject.FindGameObjectsWithTag ("hidbl");
			next++;
			if (next % 24 == 0 && ls != 0) {
				ls--;
				nxt = GameObject.FindGameObjectsWithTag ("nex");
				Destroy (nxt [0]);
			}
			k = (int)Random.Range (0, msc.Length);
			Destroy (msc[k]);
		}
		a = (int)Random.Range (1, 10f);
		b = (int)Random.Range (1, 10f);
		cl = (int)Random.Range (1, 3f);
		switch (cl) {
		case 1:
			an = a + b;
			ans.text = a + " + " + b;
			break;
		case 2:
			if (b > a) {
				cl = a;
				b = a;
				b = cl;
			}
			an = a - b;
			ans.text = a + " - " + b; 
			break;
		}
	}
}
