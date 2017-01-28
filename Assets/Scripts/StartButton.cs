using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        Scene scene = SceneManager.GetSceneByName("Flappy");
        SceneManager.LoadScene(scene.name);
    }
}
