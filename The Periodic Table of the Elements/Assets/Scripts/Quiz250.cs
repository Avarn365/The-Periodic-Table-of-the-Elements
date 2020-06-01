using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz250 : MonoBehaviour
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
            QuestionText.text = "The sun is an example of a star that burns hydrogen.";
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
            QuestionText.text = "Tin's chemical symbol is Tn.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "Antimony was known to humans since ancient times.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "Ruthenium gets its name from the Latin word for Russia, Ruthenia.";
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
            QuestionText.text = "Lead is sometimes found free in nature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Osmium and iridium were discovered at the same time.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "On average, humans consume about 6 grams of boron a day from food.";
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
            QuestionText.text = "There is no more than one ounce of francium in the Earth's crust at any one time.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "Vanadium is the least resistant element to corrosion.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "Chromium is often added to steel to harden it.";
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
            QuestionText.text = "Most of the zirconium we take in tends to accumulate in the skeleton.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "Niobium was originally known as columbium.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "Palladium was named after Pallas and the Greek god of agriculture.";
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
            QuestionText.text = "Nitrogen is used as a protective shield during the production of semiconductors.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Sodium and chlorine come together to form table salt.";
            correctAnswer = "true";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $100.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $100.";
            RetryButtonText.text = "Play Again";
        }
    }
}
