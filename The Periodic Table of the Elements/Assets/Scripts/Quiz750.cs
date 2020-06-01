using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz750 : MonoBehaviour
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
            QuestionText.text = "To obtain boron in large quantities, borax is heated with carbon.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 2)
        {
            QuestionText.text = "Vanadium's atomic mass is roughly 51.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 3)
        {
            QuestionText.text = "Bismuth-209 has an estimated half-life of 19 quadrillion years.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 4)
        {
            QuestionText.text = "One ton of uranium ore contains about 0.1 grams of polonium.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "A cyclotron is used to bombard atoms with other atoms to form new elements.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "Rhodium is obtained as a byproduct of mining nickel in Ontario, Canada.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 7)
        {
            QuestionText.text = "Antimony is element 50 on the Periodic Table.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 8)
        {
            QuestionText.text = "Promethium is naturally occurring.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 9)
        {
            QuestionText.text = "Methylmercury, a form of mercury, accumulates in the flesh of fish.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Thallium alloys with sulfur, selenium and arsenic to form low melting glass.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "Hafnium gets its name from the word half.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 12)
        {
            QuestionText.text = "It is reported that argon fluorohydride decomposes at 0C.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 13)
        {
            QuestionText.text = "Liquid chlorine can burn skin on contact.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 14)
        {
            QuestionText.text = "Zinc's name comes from the German word zink.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "All gold currently refined could fit into a 10 meter by 10 meter by 10 meter cube.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "Erbium is a rare earth element.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 17)
        {
            QuestionText.text = "Plutonium-238 is the most stable plutonium isotope.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 18)
        {
            QuestionText.text = "Dysprosium was first discovered as an impurite in euxenite.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 19)
        {
            QuestionText.text = "Lead was once used by the ancient Romans to make water pipes.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "Only 0.00000005 grams of astatine have been produced to date.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "Beta-minus decay is where one of the protons in a radioactive atom's nucleus turns into a neutron, an electron and a neutrino.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 22)
        {
            QuestionText.text = "Niobium's density is less than 8 grams per cubic centimeter.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 23)
        {
            QuestionText.text = "Orthorhombic sulfur is the most stable allotrope of sulfur.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 24)
        {
            QuestionText.text = "Fluorine is added to city water in about a one part per million proportion to prevent tooth decay.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Radium's name comes from radius, the Latin word for ray.";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $500.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $500.";
            RetryButtonText.text = "Play Again";
        }
    }
}