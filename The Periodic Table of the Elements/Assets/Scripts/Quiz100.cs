using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz100 : MonoBehaviour
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
        int randomQuestion = Random.Range(1, 26);
        SubtitleText.text = "";
        yourAnswer = "";

        if (randomQuestion == 1)
        {
            QuestionText.text = "Hydrogen is the most abundant element in the universe.";
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
            QuestionText.text = "Boron is not an important element for cell walls in plants.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "If an element is inert, it can not easily form compounds with other elements.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "The chemical symbol for sodium is Na.";
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
            QuestionText.text = "The two allotropes of silicon at room temperature are amorphous and crystalline.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Potassium gets its name from the English word potash.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "Bromine is a gas at room temperature.";
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
            QuestionText.text = "Bismuth is a radioactive element with no stable isotopes.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "Oxygen was discovered before 1700.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "About 0.57% of the Earth's crust contains titanium compounds.";
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
            QuestionText.text = "Silver has antibacterial properties that can kill most lower organisms.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "Iodine's boiling point is less than 500K.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "About 0.01% of the Earth's atmosphere is xenon gas.";
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
            QuestionText.text = "Cadmium is a poisonous metal.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Lanthanium is located at period 6 and group 4.";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win nothing...";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win nothing...";
            RetryButtonText.text = "Play Again";
        }
    }
}
