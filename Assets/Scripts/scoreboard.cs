using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreboard : MonoBehaviour
{
	public int _highscore = 0;
    public int prevScore;
	[SerializeField]
	private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        prevScore = _highscore;
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (prevScore != _highscore)
        {
            updateScore();
            prevScore = _highscore;
        }
      //  Debug.Log("Score is " + _highscore);
    }

    public void updateScore()
    {
        scoreText.text = "Score: " + _highscore;
    }
}
