using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    string highScoreKey = "HighScore";

    void OnTriggerExit2D()
    {
        NewGame.score++;
        var text = GameObject.Find("ScoreBoard").GetComponent<Text>();

        text.text = "Score: " + NewGame.score.ToString();

        UpdateHighScore();
    }

    void UpdateHighScore()
    {
        var highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        if(NewGame.score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, NewGame.score);

            var text = GameObject.Find("HighScore").GetComponent<Text>();
            text.text = "High Score: " + NewGame.score.ToString();
        }
    }
}
