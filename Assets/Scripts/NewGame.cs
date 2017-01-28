using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    public static GameStatus status;
    public static int score = 0;
    string highScoreKey = "HighScore";

    public void Start()
    {
        var highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        var text = GameObject.Find("HighScore").GetComponent<Text>();
        text.text = "High Score: " + highScore.ToString();
        Time.timeScale = 0;
        status = GameStatus.MainMenu;
    }

    public void Update()
    {
        switch (status)
        {
            case GameStatus.MainMenu:
                break;
            case GameStatus.Paused:
                break;
            case GameStatus.WaitingStart:
                break;
            case GameStatus.Started:
                Time.timeScale = 1;
                break;
            case GameStatus.Restarting:
                Invoke("Restart", 2f);
                status = GameStatus.WaitingStart;
                break;
            default:
                break;
        }   
    }

    void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        score = 0;
    }

    public void MenuStart()
    {
        status = GameStatus.WaitingStart;
    }

    public enum GameStatus
    {
        MainMenu,
        Paused,
        WaitingStart,
        Started,
        Restarting
    }
}


