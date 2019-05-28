using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	private int n = 0;

	void OnMouseUpAsButton()
	{
		SceneManager.LoadScene ("Game_1");
		LifeChange.lose = false;
		//LifeChange.life = StartProg.TLife;

		if (StartProg.Life >= 7)
			StartProg.Life = 7;
		if (StartProg.TLife > 7) {
			StartProg.Life = StartProg.TLife;
			StartProg.TLife = 7;
		}
		LifeChange.life = StartProg.Life;
		n = ScoreChange.score;
		if (n > StartProg.MaxScore) 
		{
			StartProg.MaxScore = n;
			//StartProg.ReStore ();
		}

		StartProg.Money += n / 2;
		StartProg.ReStore ();
		ScoreChange.score = 0;
		ScoreChange.n = 4;
		//WaitForSeconds (2f);
	}
}
