using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz50000 : MonoBehaviour
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
            QuestionText.text = "Hydrogen is a part of the compound ammonia.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 2)
        {
            QuestionText.text = "Silver was thought to be used by people for over 5,000 years.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 3)
        {
            QuestionText.text = "Yttrium was discovered after 1800.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 4)
        {
            QuestionText.text = "Niobium makes superconductive magnets and wires when alloyed with cobalt.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 5)
        {
            QuestionText.text = "A minus sign before an element's dscovery year indicates that the element was discovered in or around that year, BC.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 6)
        {
            QuestionText.text = "Anemia is caused by iron deficiency, which is a lack of proper iron intake.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 7)
        {
            QuestionText.text = "Europium is used widely as a blue phosphor in TV sets.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 8)
        {
            QuestionText.text = "Gadolinium is an alkaline earth metal.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 9)
        {
            QuestionText.text = "Monazite sand is a material rich in rare earth elements.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 10)
        {
            QuestionText.text = "Ytterbium has been noted to stimulate metabolism.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 11)
        {
            QuestionText.text = "The Latin word for gold is argentum.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 12)
        {
            QuestionText.text = "Uranium-235 is the most stable isotope of uranium.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 13)
        {
            QuestionText.text = "Actinium's atomic symbol is Ac.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 14)
        {
            QuestionText.text = "Beryllium was once known as glucinium because its compounds taste sweet.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 15)
        {
            QuestionText.text = "A minus sign before a radioactive element's atomic mass means that it has a negative weight.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 16)
        {
            QuestionText.text = "French chemist Antoine-Laurent Lavoisier gave oxygen its name after incorrectly believing that it was necessary to form all acids.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 17)
        {
            QuestionText.text = "Mangnesium gets its name from the Latin word for magnet, magnes.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 18)
        {
            QuestionText.text = "A getter is used for capturing neutrons in a nuclear reactor.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 19)
        {
            QuestionText.text = "Lithium is used in rechargeable batteries for mobile phones, laptops and digital cameras.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 20)
        {
            QuestionText.text = "Mercury is a liquid at room temperature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 21)
        {
            QuestionText.text = "The first pure scandium was produced in 1940.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 22)
        {
            QuestionText.text = "Tantalum is frequently used as a substitute for lead.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 23)
        {
            QuestionText.text = "Platinum can occur free in nature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 24)
        {
            QuestionText.text = "Helium can be found in some natural gas deposits.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 25)
        {
            QuestionText.text = "Chromium(IV) is essential for humans and is the main route for chromium uptake.";
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
            QuestionText.text = "Berkelium's boiling point is greater than 1000K";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $25,000.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $25,000.";
            RetryButtonText.text = "Play Again";
        }
    }
}
