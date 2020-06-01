using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz10000 : MonoBehaviour
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
        int randomQuestion = Random.Range(1, 51);
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
            QuestionText.text = "Neon is element 10 in the Periodic Table.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 14)
        {
            QuestionText.text = "Rubidium is located at period 5 and group 1.";
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
            QuestionText.text = "There are two known stable isotopes of fluorine.";
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
            QuestionText.text = "Lithium is located at period 2 and group 1.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 24)
        {
            QuestionText.text = "Cadmium is a poisonous metal.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Ytterbium was discovered before 1700.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 26)
        {
            QuestionText.text = "Promethium is named after a mythological figure.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 27)
        {
            QuestionText.text = "Palladium and cerium are both named after asteroids.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 28)
        {
            QuestionText.text = "The sun has about 8 billion years' worth of fuel left.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 29)
        {
            QuestionText.text = "Berkelium's boiling point is greater than 1000K.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 30)
        {
            QuestionText.text = "Antimony was known to humans since ancient times.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 31)
        {
            QuestionText.text = "The chemical formula for cinnabar is HgS.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 32)
        {
            QuestionText.text = "If an element is teratogenic, it can disrupt an ecosystem's biodiversity.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 33)
        {
            QuestionText.text = "Francium is used in nuclear reactors.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 34)
        {
            QuestionText.text = "Lead is sometimes found free in nature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 35)
        {
            QuestionText.text = "Polonium was first obtained from a material called pitchblende.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 36)
        {
            QuestionText.text = "On average, humans consume about 6 grams of boron a day from food.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 37)
        {
            QuestionText.text = "Gold is not a very good conductor of heat and electricity.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 38)
        {
            QuestionText.text = "Thallium can displace potassium around the body.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 39)
        {
            QuestionText.text = "There is no more than one ounce of francium in the Earth's crust at any one time.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 40)
        {
            QuestionText.text = "Vanadium is the least resistant element to corrosion.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 41)
        {
            QuestionText.text = "Chromium is often added to steel to harden it.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 42)
        {
            QuestionText.text = "Neon is the fourth most abundant element in the Earth's atmosphere.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 43)
        {
            QuestionText.text = "Molybdenum is obtained as a byproduct of diamond and silicon mining.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 44)
        {
            QuestionText.text = "Protactinium's name comes from \"the parent of actinium\" in Greek.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 45)
        {
            QuestionText.text = "Niobium was originally known as columbium.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 46)
        {
            QuestionText.text = "Iodine-131 is used for treating some diseases of the spinal cord.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 47)
        {
            QuestionText.text = "Praseodymium is element number 61 on the Periodic Table.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 48)
        {
            QuestionText.text = "Yttrium is located at period 5 and group 3.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 49)
        {
            QuestionText.text = "Uranium was discovered before 1800.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 50)
        {
            QuestionText.text = "Cesium's melting point is less than 300K.";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $7,500.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $7,500.";
            RetryButtonText.text = "Play Again";
        }
    }
}
