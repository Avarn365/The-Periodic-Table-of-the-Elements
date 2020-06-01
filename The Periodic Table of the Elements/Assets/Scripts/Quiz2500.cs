using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz2500 : MonoBehaviour
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
            QuestionText.text = "The chemical formula for methane is CH4.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 2)
        {
            QuestionText.text = "Fertilizers containing nitrogen are added to crops to increase crop yields.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 3)
        {
            QuestionText.text = "Arsenic is perfectly safe to handle and consume in large quantities.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 4)
        {
            QuestionText.text = "Potassium's chemical symbol is Pt.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "Gallium and germanium were proposed to exist based on gaps in Dimitri Mendeleyev's Periodic Table.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "Promethium's density is greater than 6 grams per cubic centimeter.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 7)
        {
            QuestionText.text = "Brass is an alloy of zinc that contains between 25% and 55% copper.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 8)
        {
            QuestionText.text = "There are four naturally occurring allotropes of carbon.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 9)
        {
            QuestionText.text = "There are three known stable isotopes of lead.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Californium-245 has a half-life of about 45 minutes.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "To get liquid arsenic, the atmospheric pressure would have to be 12 times normal.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 12)
        {
            QuestionText.text = "Gold is not a very good conductor of heat and electricity.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 13)
        {
            QuestionText.text = "Thallium can displace potassium around the body.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 14)
        {
            QuestionText.text = "Selenium was named for the Greek word for moon, selene.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "Palladium is obtained as a byproduct of mining and refining sulfur and silicon.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "Silver is the best known reflector of light.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 17)
        {
            QuestionText.text = "Neon is the fourth most abundant element in the Earth's atmosphere.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 18)
        {
            QuestionText.text = "Molybdenum is obtained as a byproduct of diamond and silicon mining.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 19)
        {
            QuestionText.text = "A Weston cell is a battery used to produce a precise voltage for calibrating medical equipment.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "There are certain organo-tin compounds that are poisonous.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "Thyroxin is a toxin that slows the mental development of organisms.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 22)
        {
            QuestionText.text = "Praseodymium is element number 61 on the Periodic Table.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 23)
        {
            QuestionText.text = "Rhenium is a transition metal.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 24)
        {
            QuestionText.text = "Nobelium-259 is the most stable nobelium isotope.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Humans need only about 0.01 milligrams of vanadium a day.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 26)
        {
            QuestionText.text = "Astatine can not occur naturally.";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $1,000.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $1,000.";
            RetryButtonText.text = "Play Again";
        }
    }
}