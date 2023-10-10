using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float delayTime = 1.5f;

    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "test1correct" || currentScene == "test1wrong")
        {
            Invoke("LoadTest2Scene", delayTime);
        }
        else if (currentScene == "test2correct" || currentScene == "test2wrong")
        {
            Invoke("LoadTest3Scene", delayTime);
        }
        else if (currentScene == "test3correct" || currentScene == "test3wrong")
        {
            Invoke("LoadEndingScene", delayTime);
        }
    }

    void LoadTest2Scene()
    {
        SceneManager.LoadScene("test2");
    }

    void LoadTest3Scene()
    {
        SceneManager.LoadScene("test3");
    }

    void LoadEndingScene()
    {
        SceneManager.LoadScene("ending");
    }
}









