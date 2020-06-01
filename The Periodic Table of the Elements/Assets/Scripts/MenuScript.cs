using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void ExploreButton()
    {
        SceneManager.LoadScene("ExploreScene");
    }

    public void QuizButton()
    {
        SceneManager.LoadScene("100QuizScene");
    }

    public void SourcesButton()
    {
        SceneManager.LoadScene("SourcesScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
