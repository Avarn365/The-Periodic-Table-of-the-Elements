using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz500000 : MonoBehaviour
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
        int randomQuestion = Random.Range(1, 76);
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

        else if (randomQuestion == 26)
        {
            QuestionText.text = "The sun is an example of a star that burns hydrogen.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 27)
        {
            QuestionText.text = "Fertilizers containing nitrogen are added to crops to increase crop yields.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 28)
        {
            QuestionText.text = "Arsenic is perfectly safe to handle and consume in large quantities.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 29)
        {
            QuestionText.text = "Tin's chemical symbol is Tn.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 30)
        {
            QuestionText.text = "Antimony was known to humans since ancient times.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 31)
        {
            QuestionText.text = "Ruthenium gets its name from the Latin word for Russia, Ruthenia.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 32)
        {
            QuestionText.text = "Brass is an alloy of zinc that contains between 25% and 55% copper.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 33)
        {
            QuestionText.text = "There are four naturally occurring allotropes of carbon.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 34)
        {
            QuestionText.text = "Lead is sometimes found free in nature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 35)
        {
            QuestionText.text = "Osmium and iridium were discovered at the same time.";
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
            QuestionText.text = "Most of the zirconium we take in tends to accumulate in the skeleton.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 45)
        {
            QuestionText.text = "Niobium was originally known as columbium.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 46)
        {
            QuestionText.text = "Palladium was named after Pallas and the Greek god of agriculture.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 47)
        {
            QuestionText.text = "Praseodymium is element number 61 on the Periodic Table.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 48)
        {
            QuestionText.text = "Rhenium is a transition metal.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 49)
        {
            QuestionText.text = "Nitrogen is used as a protective shield during the production of semiconductors.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 50)
        {
            QuestionText.text = "Sodium and chlorine come together to form table salt.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 51)
        {
            QuestionText.text = "Hydrogen is a part of the compound ammonia.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 52)
        {
            QuestionText.text = "Silver was thought to be used by people for over 5,000 years.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 53)
        {
            QuestionText.text = "Yttrium was discovered after 1800.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 54)
        {
            QuestionText.text = "Niobium makes superconductive magnets and wires when alloyed with cobalt.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 55)
        {
            QuestionText.text = "A minus sign before an element's discovery year indicates that the element was discovered in or around that year, BC.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 56)
        {
            QuestionText.text = "Anemia is caused by iron deficiency, which is a lack of proper iron intake.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 57)
        {
            QuestionText.text = "Europium is used widely as a blue phosphor in TV sets.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 58)
        {
            QuestionText.text = "Gadolinium is an alkaline earth metal.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 59)
        {
            QuestionText.text = "Monazite sand is a material rich in rare earth elements.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 60)
        {
            QuestionText.text = "Ytterbium has been noted to stimulate metabolism.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 61)
        {
            QuestionText.text = "The Latin word for gold is argentum.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 62)
        {
            QuestionText.text = "Uranium-235 is the most stable isotope of uranium.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 63)
        {
            QuestionText.text = "Actinium's atomic symbol is Ac.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 64)
        {
            QuestionText.text = "Beryllium was once known as glucinium because its compounds taste sweet.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 65)
        {
            QuestionText.text = "A minus sign before a radioactive element's atomic mass means that it has a negative weight.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 66)
        {
            QuestionText.text = "French chemist Antoine-Laurent Lavoisier gave oxygen its name after incorrectly believing that it was necessary to form all acids.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 67)
        {
            QuestionText.text = "Mangnesium gets its name from the Latin word for magnet, magnes.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 68)
        {
            QuestionText.text = "A getter is used for capturing neutrons in a nuclear reactor.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 69)
        {
            QuestionText.text = "Lithium is used in rechargeable batteries for mobile phones, laptops and digital cameras.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 70)
        {
            QuestionText.text = "Mercury is a liquid at room temperature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 71)
        {
            QuestionText.text = "The first pure scandium was produced in 1940.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 72)
        {
            QuestionText.text = "Tantalum is frequently used as a substitute for lead.";
            correctAnswer = "false";
        }

        else if (randomQuestion == 73)
        {
            QuestionText.text = "Platinum can occur free in nature.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 74)
        {
            QuestionText.text = "Helium can be found in some natural gas deposits.";
            correctAnswer = "true";
        }

        else if (randomQuestion == 75)
        {
            QuestionText.text = "Meitnerium is located at period 7 and group 8.";
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
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $250,000.";
            RetryButtonText.text = "Play Again";
        }

        else if (correctAnswer == "false" && yourAnswer == "true")
        {
            SubtitleText.text = "Incorrect. It is " + correctAnswer + ". You win $250,000.";
            RetryButtonText.text = "Play Again";
        }
    }
}