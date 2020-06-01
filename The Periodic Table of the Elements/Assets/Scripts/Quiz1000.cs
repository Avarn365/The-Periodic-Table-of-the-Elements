using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz1000 : MonoBehaviour
{
    public Text QuestionText;
    public Text SubtitleText;
    public Text RetryButtonText;
    public GameObject TrueButton;
    public GameObject FalseButton;
    private string correctAnswer;
    private string yourAnswer;
    private int nextCountdown = 100000000;

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("100QuizScene");
    }

    public void TrueButtonPress()
    {
        yourAnswer = "true";
        TrueButton.SetActive(false);
        FalseButton.SetActive(false);
    }

    public void FalseButtonPress()
    {
        yourAnswer = "false";
        TrueButton.SetActive(false);
        FalseButton.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        int randomQuestion = Random.Range(1, 27);
        SubtitleText.text = "";
        yourAnswer = "";

        if (randomQuestion == 1)
        {
            QuestionText.text = "When the isotope berkelium-243 was created, two free neutrons were also created.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 2)
        {
            QuestionText.text = "Nitrogen is the most abundant element in the Earth's atmosphere.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 3)
        {
            QuestionText.text = "Chlorine is a noble gas.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 4)
        {
            QuestionText.text = "Curium is a transition metal.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "Radium is element 88 on the Periodic Table.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "The nitrogen cycle is a process used by living organisms to recycle nitrogen.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 7)
        {
            QuestionText.text = "Magnesium can be found free in nature.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 8)
        {
            QuestionText.text = "Aluminum and lithium are both alkali metals.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 9)
        {
            QuestionText.text = "Neptunium-239's half-life is about 2.4 days.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Americium is being considered for use in portable gamma ray sources.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "Pure tungsten is so hard, it cannot be cut with a hacksaw.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 12)
        {
            QuestionText.text = "Gold's chemical symbol is Gd.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 13)
        {
            QuestionText.text = "When heated at normal pressure, arsenic turns from a solid straight into a gas.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 14)
        {
            QuestionText.text = "Krypton is a gas at room temperature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "After 8 half-lives of a radioactive element, 1/128 of the initial amount of that element remains.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "For centuries, cobalt has been used for coloring porcelain, glass, pottery, tile and enamel.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 17)
        {
            QuestionText.text = "It is confirmed that germanium has health benefits.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 18)
        {
            QuestionText.text = "Selenium is a transition metal.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 19)
        {
            QuestionText.text = "Uranium trioxide has been used in the manufacture of Fiestaware plates.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "Holmium has unusual magnetic properties.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "Technetium is an actinoid.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 22)
        {
            QuestionText.text = "Samarium was discovered before 1800.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 23)
        {
            QuestionText.text = "Radon is a gas at room temperature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 24)
        {
            QuestionText.text = "Chromium(III) is essential for humans and is the main route for chromium uptake.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Thulium does not occur in nature.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 26)
        {
            QuestionText.text = "Chlorine was used as a chemical weapon by the Allies in World War I.";
            correctAnswer = "false";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (correctAnswer == "true" && yourAnswer == "true")
        {
            SubtitleText.text = "Correct! It is " + correctAnswer + ".";

            while (nextCountdown > 0)
            {
                nextCountdown = nextCountdown - 1;
                if (nextCountdown == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }

        }

        else if (correctAnswer == "false" && yourAnswer == "false")
        {
            SubtitleText.text = "Correct! It is " + correctAnswer + ".";

            while (nextCountdown > 0)
            {
                nextCountdown = nextCountdown - 1;
                if (nextCountdown == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }

        }

        else if (correctAnswer == "true" && yourAnswer == "false")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $750.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $750.";
            RetryButtonText.text = "Play Again";
        }
    }
}