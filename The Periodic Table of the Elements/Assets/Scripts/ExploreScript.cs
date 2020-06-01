using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExploreScript : MonoBehaviour
{
    public Slider elementSlider;

    public Text elementNumberText;
    public Text elementNameText;
    public Text elementSymbolText;
    public Text elementMassText;
    public Text elementMeltingPointText;
    public Text elementBoilingPointText;
    public Text elementRoomTempPhaseText;
    public Text elementClassificationText;
    public Text elementPeriodText;
    public Text elementGroupText;
    public Text elementDiscovererText;
    public Text elementYearDiscoveredText;
    public Text elementIonizationText;
    public Text elementDensityText;
    public Text elementStableIsotopesText;
    public Text elementInfoText;

    private float atomicNumber;
    private string atomicName;
    private string atomicSymbol;
    private double atomicMass;
    private double atomicMelt;
    private double atomicBoil;
    private string atomicPhase;
    private string atomicClass;
    private int atomicPeriod;
    private int atomicGroup;
    private string atomicDiscoverer;
    private int atomicYear;
    private double atomicIon;
    private double atomicDensity;
    private int atomicIsotopes;
    private string atomicInfo;

    void SetNumberText()
    {
        elementNumberText.text = "Element " + elementSlider.value.ToString();
    }

    void SetNameText()
    {
        elementNameText.text = atomicName;
    }

    void SetSymbolText()
    {
        elementSymbolText.text = atomicSymbol;
    }

    void SetMassText()
    {
        elementMassText.text = atomicMass.ToString();
    }

    void SetMeltText()
    {
        elementMeltingPointText.text = "Melting Point: " + atomicMelt.ToString() + " K";
    }

    void SetBoilText()
    {
        elementBoilingPointText.text = "Boiling Point: " + atomicBoil.ToString() + " K";
    }

    void SetPhaseText()
    {
        elementRoomTempPhaseText.text = "Phase At Room Temp.: " + atomicPhase;
    }

    void SetClassText()
    {
        elementClassificationText.text = "Class: " + atomicClass;
    }

    void SetPeriodText()
    {
        elementPeriodText.text = "Period: " + atomicPeriod.ToString();
    }

    void SetGroupText()
    {
        elementGroupText.text = "Group: " + atomicGroup.ToString();
    }

    void SetDiscovererText()
    {
        elementDiscovererText.text = "Discoverer(s): " + atomicDiscoverer;
    }

    void SetYearText()
    {
        elementYearDiscoveredText.text = "Year Discovered: " + atomicYear.ToString();
    }

    void SetIonText()
    {
        elementIonizationText.text = "Ionization: " + atomicIon.ToString() + " eV";
    }

    void SetDensityText()
    {
        elementDensityText.text = "Density (g/cbcm): " + atomicDensity.ToString();
    }

    void SetIsotopesText()
    {
        elementStableIsotopesText.text = "Known Stable Isotopes: " + atomicIsotopes.ToString();
    }

    void SetInfoText()
    {
        elementInfoText.text = atomicInfo;
    }

    void SetAllText()
    {
        SetNumberText();
        SetNameText();
        SetSymbolText();
        SetMassText();
        SetMeltText();
        SetBoilText();
        SetPhaseText();
        SetClassText();
        SetPeriodText();
        SetGroupText();
        SetDiscovererText();
        SetYearText();
        SetIonText();
        SetDensityText();
        SetIsotopesText();
        SetInfoText();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    void Start()
    {
        elementSlider.minValue = 1;
        elementSlider.maxValue = 118;
        elementSlider.wholeNumbers = true;
        elementSlider.value = 1;
        atomicNumber = elementSlider.value;
        SetAllText();
    }

    public void OnValueChanged(float value)
    {
        SetAllText();
    }

    void Update()
    {
        if (elementSlider.value == 1)
        {
            atomicName = "Hydrogen";
            atomicSymbol = "H";
            atomicMass = 1.0079;
            atomicMelt = 13.81;
            atomicBoil = 20.28;
            atomicPhase = "Gas";
            atomicClass = "Non-Metal";
            atomicPeriod = 1;
            atomicGroup = 1;
            atomicDiscoverer = "Henry Cavendish";
            atomicYear = 1766;
            atomicIon = 13.598;
            atomicDensity = 0.00008988;
            atomicIsotopes = 2;
            atomicInfo = "Hydrogen, an element whose name comes from the Greek words hydro and genes, which come together to mean \"water forming,\" is the most abundant element in the entire known universe. In fact, it is estimated that 90% of the visible universe is composed of hydrogen. This is because hydrogen is the raw fuel that many stars throughout the universe burn to produce energy in a process known as fusion. The sun is an example of a hydrogen-burning star. It has about 5 billion years' worth of fuel left.\n\nHydrogen is a commercially important element on Earth. Large amounts of hydrogen combine with nitrogen in the air to form ammonia (NH3), commonly used in cleaning products. This formation of ammonia is called the Haber-Bosch process, named after German chemists Fritz Haber and Carl Bosch. Hydrogen is also found in many fats and oils through a process known as hydrogenation. Liquid hydrogen is used in the study of superconductors and, along with liquid oxygen, in rocket fuel.\n\nHydrogen combines with various other elements on Earth to form several different molecules. For example, water is made of two hydrogen atoms and one oxygen atom (H2O), methane is made of one carbon atom and four hydrogen atoms (CH4), and table sugar is made of twelve carbon atoms, twenty-two hydrogen atoms and eleven oxygen atoms (C12H22O11). While hydrogen has only two known stable isotopes, hydrogen has three known isotopes altogether. The first and simplest isotope, protium, is just pure hydrogen. The second isotope, deuterium, was discovered in 1932. The last isotope, tritium, was discovered in 1934.";
            SetAllText();
        }

        else if (elementSlider.value == 2)
        {
            atomicName = "Helium";
            atomicSymbol = "He";
            atomicMass = 4.0026;
            atomicMelt = 0.95;
            atomicBoil = 4.22;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 1;
            atomicGroup = 18;
            atomicDiscoverer = "Sir William Ramsey";
            atomicYear = 1895;
            atomicIon = 24.587;
            atomicDensity = 0.0001785;
            atomicIsotopes = 2;
            atomicInfo = "Helium, named after Helios, the Greek god of the sun, was first discovered on the sun before on Earth. It was discovered on the sun when French Astronomer Pierre-Jules-Cesar Janssen noticed a yellow line in the sun's spectrum while studying a total solar eclipse in 1868. Meanwhile, English astronomer Sir Norman Lockyer saw that this line had a wavelength of 587.49 nanometers, and that a wavelength of this size could not be produced at any known element at the time. It was hypothesized that a new element was at work creating the emission that led to the yellow line. Lockyer named this unknown element helium.\n\nHelium is the second most abundant element in our known universe behind hydrogen. It forms in stars when two hydrogen atoms combine to form one helium atom in what is called fusion. Helium is much less abundant in Earth's atmosphere; it makes up approximately 0.0005% of the air we breathe. The helium on Earth is not gravitationally bound to the planet and is constantly being lost to space. The lost helium is replaced by the decay of radioactive elements in the Earth's crust. The type of radioactive decay that creates alpha particles that will eventually become new helium atoms is called alpha decay. When these alpha particles capture two electrons to become helium, they work their way to the top of the atmosphere and into space as the cycle repeats again.\n\nIt is very difficult to extract helium gas from the air, but there are natural gas deposits that are rich in helium. Helium gas is used in blimps and many different types of balloons to keep them afloat. It is used as an inert shield for welding, fuel pressurization in liquid-fueled rockets and supersonic tunnels. Along with oxygen, helium helps create a a nitrogen-free atmosphere for deep sea divers to prevent a condition called nitrogen narcosis. In liquid form, helium is used for studying superconductivity and creating supercondictive magnets.\n\nSince helium is an inert gas, it does not easily combine with other elements, and because it does not combine with other elements easily, there are no known compounds that contain helium. However, despite its inert state, attempts are being made at producing a compound called helium diflouride (HeF2).";
            SetAllText();
        }

        else if (elementSlider.value == 3)
        {
            atomicName = "Lithium";
            atomicSymbol = "Li";
            atomicMass = 6.941;
            atomicMelt = 453.65;
            atomicBoil = 1615;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 2;
            atomicGroup = 1;
            atomicDiscoverer = "Johan August Arfvedson";
            atomicYear = 1817;
            atomicIon = 5.392;
            atomicDensity = 0.534;
            atomicIsotopes = 2;
            atomicInfo = "Lithium, named for the Greek word for stone, lithos, was first discovered within the mineral petalite (LiAl(Si2O5)2). It is the only alkali metal to be discovered in a mineral, while the others were discovered in plant material. Lithium only makes up 0.0007% of the Earth's crust, but it cannot be found free in nature. To obtain pure lithium, you would have to run large amounts of lithium chloride (LiCl) through electrolysis to separate the lithium and chlorine that make up this compound.\n\nLithium and compounds containing lithium have several different uses in producing different stuff. This is because lithium has the highest specific heat of any solid element and is also the lightest and least dense known metal. Because it has such high heat capacity, lithium is commonly used in heat transfer applications. It is used to make special types of glasses and ceramics, including a 200-inch mirror that is used on the Mount Palomar telescope in California. Because lithium is so light, it can be alloyed with other light metals such as aluminum, copper, manganese and cadmium for strong, lightweight materials for aircraft. Lithium hydroxide (LiOH) is used for removing carbon dioxide from the atmosphere of spacecraft, lithium stearate (LiC18H35O2) is used as a lubricant for high-temperature environments, and lithium carbonate (Li2CO3) is used as a drug for treating manic depression disorder (although its action on the brain is still not yet fully understood).\n\nPerhaps the most important role of lithium is its use in rechargeable batteries found in mobile phones, laptops, digital cameras and electric vehicles. Lithium is also used in non-rechargeable batteries seen in pacemakers, toys, clocks and almost anything else electronic.\n\nLithium is a toxic metal, but not in very small doses, and it reacts violently with water, though not as much as sodium.";
            SetAllText();
        }

        else if (elementSlider.value == 4)
        {
            atomicName = "Beryllium";
            atomicSymbol = "Be";
            atomicMass = 9.0122;
            atomicMelt = 1560;
            atomicBoil = 2744;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 2;
            atomicGroup = 2;
            atomicDiscoverer = "Nicholas Louis Vauquelin";
            atomicYear = 1797;
            atomicIon = 9.323;
            atomicDensity = 1.85;
            atomicIsotopes = 1;
            atomicInfo = "Beryllium, deriving from the Greek word beryl, a type of mineral, was first discovered as an unknown element in emeralds, but it wasn't successfully isolated from the compounds that it is part of until 1829 when chemists Friedrich Wolhler of Germany and Antoine-Alexandere-Brutus Bussy of France reduced beryllium chloride (BeCl2) with potassium. Today, pure beryllium can be obtained through beryl (Be3Al2(SiO3)6) via a chemical process or through the electrolysis of a mixture of molten beryllium chloride (BeCl2) and sodium chloride (NaCl).\n\nBeryllium is used to make windows for X-ray tubes due to it being relatively transparent to X-rays. Beryllium is alloyed with copper to form a wear-resistant metal known as beryllium bronze for use in gyroscopes and other devices where wear-resistance is important. When it is alloyed with nickel, on the other hand, it can be used to make springs, spot-welding electrodes and non-sparking tools. Other beryllium alloys are used for windshields, brake disks and other space shuttle components. When beryllium is compounded with oxygen to form beryllium oxide (BeO), it is used for work with the nuclear and ceramic industries.\n\nDid you know that beryllium was once known as glucinium, coming from the Greek word glykys, which means sweet, because its compounds tasted sweet? If you are thinking about taking a lick out of some beryllium, don't! Beryllium and the many compounds that it forms are toxic and should never be consumed or digested.";
            SetAllText();
        }

        else if (elementSlider.value == 5)
        {
            atomicName = "Boron";
            atomicSymbol = "B";
            atomicMass = 10.811;
            atomicMelt = 2348;
            atomicBoil = 4273;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 2;
            atomicGroup = 13;
            atomicDiscoverer = "Sir Humphry Davy";
            atomicYear = 1808;
            atomicIon = 8.298;
            atomicDensity = 2.37;
            atomicIsotopes = 2;
            atomicInfo = "Boron, whose name comes from the Arabic word buraq and the Persian word burah, both of which stand for the material borax, was first discovered when it was isolated from boric acid (H3BO3) with potassium. Boron is obtained in large quantities today through heating borax (Na2B4O7 * 10H2O) with carbon, if high-purity boron is needed, hydrogen is applied to boron trichloride (BCl3) or boron tribromide (BBr3) to reduce them to just pure boron.\n\nBorax, boric acid and boric oxide (B2O3) are the most economically important compounds of boron, as they are used in a variety of household liquids, including eye drops, mild antiseptics, washing powders and tile glazes. Borax, at one point, was also used in bleach and as a food preservative. Boric oxide is used in making borosilicate glass, or Pyrex, because it makes the glass tougher to break and more resistant to heat. Other compounds containing boron are used as enamels for covering steel and as a potential arthritis medicine and brain tumor treatment.\n\nBoron is essential for the cell walls in plants, and it is typically nonpoisonous to animals in small doses, but it can disrupt the body's metabolism if consumed in higher amounts. The average human consumes around 2 milligrams of boron every day from our food, which adds up to around 60 grams in our lifetime. Boron can also be found in some volcanic spring waters and in extensive borax deposits in Turkey. The most important source of boron, however, is rasorite, found in the Mojave Desert in California in the United States.";
            SetAllText();
        }

        else if (elementSlider.value == 6)
        {
            atomicName = "Carbon";
            atomicSymbol = "C";
            atomicMass = 12.0107;
            atomicMelt = 3823;
            atomicBoil = 4098;
            atomicPhase = "Solid";
            atomicClass = "Non-Metal";
            atomicPeriod = 2;
            atomicGroup = 14;
            atomicDiscoverer = "N/A";
            atomicYear = 0;
            atomicIon = 11.260;
            atomicDensity = 2.2670;
            atomicIsotopes = 2;
            atomicInfo = "Carbon, whose name derives from the Latin word carbo, meaning charcoal, is the sixth most abundant element in the known universe and has been known since ancient times. Carbon is most easily obtainable from coal deposits, but it usually must be processed into a form that is suitable for commercial use. There are three naturally occurring allotropes of carbon currently known to exist: amorphous, graphite and diamond.\n\nAmorphous carbon forms when a material containing carbon is burned with not enough oxygen to burn completely. The black soot that forms from this is called carbon black, but it is also referred to as lampblack, gas black and channel black. Carbon black is used for making inks, paints and rubber products. It can also be pressed into shapes to form the cores of most dry cell batteries.\n\nGraphite is the softest naturally occurring form of carbon, so it is primarily used as a lubricant. To get this form of carbon, industries treat petroleum coke, which is a black tar residue that remains after refining crude oil, in an oxygen-free-oven. Graphite, in addition to its use as a lubricant, is also used to produce steel and the black material inside pencils.\n\nDiamond is the third naturally-occurring form of carbon and is one of the hardest known substances. Naturally-occurring diamons is typically used in jewelry, but most commercial quality diamonds are produced artificially. Artificial diamonds are created by squeezing graphite under very high temperatures for many days or weeks and are primarily used for making diamond-tipped saw blades. The only difference between graphite and diamond is the crystal structure that they have.\n\nThere is a fourth allotrope of carbon called white carbon that was produced in 1969. It is a transparent material that can split a single beam of light in two, a property called birefringence. Despite this form of carbon being created about half a century ago, very little is  known about it.\n\nThere are a whopping ten million compounds of carbon known to mankind. So many, in fact, that there is an entire branch of chemistry reserved exclusively for their study, called organic chemistry. Some of these well-known carbon compounds include carbon dioxide (CO2), carbon monoxide (CO), carbon disulfide (CS2), chloroform (CHCl3), carbon tetrachloride (CCl4), methane (CH4), ethylene (C2H4), acetylene (C2H2), benzene (C6H6), ethyl alcohol (C2H5OH) and acetic acid (CH3COOH).\n\nBecause carbon is essential to life, it is relatively nontoxic. Many living things get the vast majority of their carbon from carbon dioxide, either from the air or dissolved in water. Plants and photosynthetic plankton use the sun's energy to split water into hydrogen and oxygen. The oxygen is released into the atmosphere and the water, while the hydrogen joins with carbon dioxide to produce carbohydrates.\n\n(Note: Any element's numeric data that has an output of 0 means that this data for the element is unknown.)";
            SetAllText();
        }

        else if (elementSlider.value == 7)
        {
            atomicName = "Nitrogen";
            atomicSymbol = "N";
            atomicMass = 14.0067;
            atomicMelt = 63.15;
            atomicBoil = 77.36;
            atomicPhase = "Gas";
            atomicClass = "Non-Metal";
            atomicPeriod = 2;
            atomicGroup = 15;
            atomicDiscoverer = "Daniel Rutherford";
            atomicYear = 1772;
            atomicIon = 14.534;
            atomicDensity = 0.0013;
            atomicIsotopes = 2;
            atomicInfo = "Nitrogen, a name that comes from the Greek words nitron and genes, which combine to mean \"saltpetre forming,\" is the fifth most abundant element in the known universe and the most abundant element in the Earth's atmosphere -- around 70% of its composition. This means that there is about 4,000 trillion tons of Nitrogen in Earth's atmosphere.\n\nThe largest use of nitrogen is for the production of ammonia (NH3), where large amounts of it are combined with hydrogen in the Haber-Bosch process. This ammonia is then used to make fertilizers, explosives and, from the Ostwald process, named after German chemist Wilhelm Ostwald, nitric acid (HNO3).\n\nNitrogen gas is largely inert and is used as a protective shield during the production of semiconductors, welding and soldiering operations. In the oil industry, to help force crude oil to the surface, nitrogen is applied at very high pressures. Liquid notrogen is a cryogenic liquid used for refeigeration, preservation of biological samples and low-temperature science experiments.\n\nNitrogen is recycled naturally by living organisms via the 'nitrogen cycle'. The nitrogen is taken in by plants and algae as nitrates and is then used to construct DNA and RNA bases, as well as amino acids, which are the building blocks of proteins. Meanwhile, animals get their nitrogen from consuming other living things. They digest the proteins and DNA into their bases and amino acids, reforming them into their use. Microbes in the soil convert the nitrogen compounds back into nitrates for plants to use again and the nitrate supply is also replenished by bacteria that fixes the nitrogen directly from the atmosphere.\n\nFinally, crop yields can be increased greatly by adding chemical fertilizers containing nitrogen to the soil, but if they are used carelessly or in excess, the fertilizer can leach out of the soil and seep into rivers and lakes, causing algae to grow quickly. This blocks out light, preventing photosynthesis and the lake or river dies as a result.";
            SetAllText();
        }

        else if (elementSlider.value == 8)
        {
            atomicName = "Oxygen";
            atomicSymbol = "O";
            atomicMass = 15.9994;
            atomicMelt = 54.36;
            atomicBoil = 90.20;
            atomicPhase = "Gas";
            atomicClass = "Non-Metal";
            atomicPeriod = 2;
            atomicGroup = 16;
            atomicDiscoverer = "Joseph Priestly";
            atomicYear = 1774;
            atomicIon = 13.618;
            atomicDensity = 0.0014;
            atomicIsotopes = 3;
            atomicInfo = "Oxygen, named for the Greek words oxys and genes, which combine to mean \"acid forming,\" was produced several times before its discovery, but chemists failed to officially recognize it as an element back then. It was finally recognized as an element after mercuric oxide (HgO) was heated. The gas that was produced from the heated oxide was called 'dephlogisticated' or 'fire' air before French chemist Antoine-Laurent Lavoisier officially gave it the name oxygen after incorrectly believing that it was necessary to form all acids.\n\nOxygen is the third most abundant element in the universe behind hydrogen and helium and makes up almost 21% of the Earth's atmosphere. Oxygen accounts for nearly half of the Earth's crust, two-thirds of the human body and nine-tenths of water, all three of which are relative to mass. Fractional distillation is a process used to extract large amounts of oxygen from liquefied air, and the heating of potassium chloride (KClO3) is another way of producing pure oxygen.\n\nOxygen is highly reactive and can combine with many other elements. It is used in many forms of combustion and for burning fuels. It is also used with high pressures to burn away impurities in pig iron to create steel. When used with acetylene (C2H2), it produces a white hot flame used for welding. Liquid oxygen and liquid hydrogen makes excellent fuel for rockets. Ozone (O3) forms a thin layer in the lower stratosphere that protects the Earth from harmful ultraviolet rays from the sun.\n\nToday, oxygen is needed for most species on Earth to breathe, but long ago, at the beginning of the Proterozoic Eon, that was a completely different story -- it was a poison for nearly all forms of life at that time. If you could travel back in time to 2.4 billion years before you were born, you would be in for a horrible surprise: You would suffocate within minutes because there was very little oxygen back then. The atmosphere at the time was composed almost entirely out of nitrogen -- about 98% to be more exact. Oxygen first appeared during this time due to cyanobacteria releasing it into the air as a waste product from photosynthesis. The mass accumulation of oxygen into the atmosphere became known as the Great Oxygenation event, one of the most important events in Earth's history. If oxygen were not present in the atmosphere today, it is extremely unlikely that you would be here reading this right now.";
            SetAllText();
        }

        else if (elementSlider.value == 9)
        {
            atomicName = "Fluorine";
            atomicSymbol = "F";
            atomicMass = 18.9984;
            atomicMelt = 53.53;
            atomicBoil = 85.03;
            atomicPhase = "Gas";
            atomicClass = "Halogen";
            atomicPeriod = 2;
            atomicGroup = 17;
            atomicDiscoverer = "Frederic Henri Moissan";
            atomicYear = 1886;
            atomicIon = 17.423;
            atomicDensity = 0.0017;
            atomicIsotopes = 1;
            atomicInfo = "Fluorine, a name deriving from the Latin and French words for flow, fluere, is the most reactive of all the elements on the periodic table, and there is unfortunately no known chemical substance that can free fluorine from any compounds it forms. Fluorine never occurs pure in nature and wass very difficult for scientists to isolate. The first time pure fluorine was obtained was when British chemist George Gore ran an electric current through hydrofluoric acid (HF). The fluorine gas that was created from the electrolysis reacted violently with the hydrogen gas that came out on in its electrode. Years later, fluorine was successfully isolated through the electrolysis of potassium fluoride (KF) and hydrofluoric acid. Today, fluorine is also obtained through the electrolysis of potassium acid fluoride (KHF2).\n\nTo prevent tooth decay, fluorine is added to city water in about a one part per million proportion. In toothpaste, sodium fluoride (NaF) and sodium monofluorophosphate (NaPO3F) are also used for preventing tooth decay. Hydrofluoric acid (HF) is used to etch glass, including most of the glass that is used in lightbulbs.\n\nFluorine compounds with carbon to form what are known as fluorocarbons. Dichlorofluoromethane (CF2Cl2), a notable example of a fluorocarbon, was used widespread in air conditioning and refrigeration systems and aerosol sprays in the late 1800s and early 1900s. There was just one problem with using this compound: While it was non-toxic to humans, it was extremely harmful to the ozone layer. At one point, it got so bad that a huge hole in the ozone layer formed above Antarctica. As a result, in 1987, 27 countries came together and signed a global environmental treaty called the Montreal Protocol to reduce the 1986 production levels of CFCs (chlorofluorocarbons), as they were known as by then, by 50% before the year 2000. An amendment to the treaty in 1990 called for the elimination of all CFC productions by 2000.";
            SetAllText();
        }

        else if (elementSlider.value == 10)
        {
            atomicName = "Neon";
            atomicSymbol = "Ne";
            atomicMass = 20.1797;
            atomicMelt = 24.56;
            atomicBoil = 27.07;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 2;
            atomicGroup = 18;
            atomicDiscoverer = "Sir William Ramsey and Morris M. Travers";
            atomicYear = 1898;
            atomicIon = 21.565;
            atomicDensity = 0.0009;
            atomicIsotopes = 3;
            atomicInfo = "Neon, whose name comes from neos, the Greek word for new, was first discovered through the study of liquefied air shortly after the discovery of krypton. It is the fourth most abundant element in the universe behind hydrogen, helium and oxygen, but makes up only 0.0018% of the Earth's atmosphere. Like helium, neon is an inert gas, meaning that it will not react with any other element, and there are no known compounds containing neon.\n\nThe biggest use for neon is in advertising signs and open signs that you see inside windows of various fast food chains and shops. The neon is inside a vacuum discharge tube, and an electrical current is run through it to give it a reddish-orange glow. Other gases can be added to neon to give the signs different colors. Neon is also used for making high-voltage indicators, lightning arresters, diving equipment and, when combined with helium, lasers. Liquid neon is used as a very improtant cryogenic refrigerant, as it has over 40 times the refrigerating capacity per unit volume than liquid helium and over three times the capacity as liquid hydrogen.";
            SetAllText();
        }

        else if (elementSlider.value == 11)
        {
            atomicName = "Sodium";
            atomicSymbol = "Na";
            atomicMass = 22.9898;
            atomicMelt = 370.95;
            atomicBoil = 1156;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 3;
            atomicGroup = 1;
            atomicDiscoverer = "Sir Humphry Davy";
            atomicYear = 1807;
            atomicIon = 5.139;
            atomicDensity = 0.97;
            atomicIsotopes = 1;
            atomicInfo = "Sodium's name comes from the English word soda and the Medieval Latin word sodanum, which means \"headache remedy,\" but sodium's chemical symbol comes from the Latin word for sodium carbonate, natrium.\n\nSodium is the sixth most abundant element on Earth and makes up about 2.6% of its crust, but it is a highly reactive element and can not be found pure in nature. The first time pure sodium was obtained was when caustic soda (NaOH) was electrolyzed and split into its elements. Sodium can ignite on contact with water, so it must be stored in a moisture-free environment.\n\nSodium is used in some nuclear reactors as a heat exchanger and in the chemical industry as a reagent. Sodium chloride (NaCl), also known as table salt, is the most common compound of sodium. It is added to food for flavor and is put on roads to de-ice them during the winter. It is also used as a feedstock for the chemical industry. Sodium carbonate, also known as washing soda, is used as a water softener.\n\nSodium is an important element to all living things, a fact known by humans since the dawn of humanity. The human body contains an average of about 100 grams of sodium, but we lose the sodium very quickly so we need to find various ways of replacing that lost sodium. The average human eats about ten grams of salt a day, but it is recommended that we eat only about three grams because any more may contribute to high blood pressure. One of the ways sodium works in the human body is that it helps cells transmit nerve signals and regulate water levels in tissues and blood.";
            SetAllText();
        }

        else if (elementSlider.value == 12)
        {
            atomicName = "Magnesium";
            atomicSymbol = "Mg";
            atomicMass = 24.305;
            atomicMelt = 923;
            atomicBoil = 1363;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 3;
            atomicGroup = 2;
            atomicDiscoverer = "Joseph Black";
            atomicYear = 1755;
            atomicIon = 7.646;
            atomicDensity = 1.74;
            atomicIsotopes = 3;
            atomicInfo = "Magnesium, named after Magnesia, a district in Thessaly, Greece, is the eighth most abundant element in the universe and the seventh most abundant element in the Earth's crust, but it can never be found free in nature. The first time pure magnesium was obtained was through the electrolysis of a mixture of magnesium oxide (MgO) and mercuric oxide (HgO) in 1808 by Sir Humphry Davy. Today, magnesium is extracted from the minerals dolomite (CaCO3 * MGCO3) and carnallite (KCl * MgCl2 * 6H2O), but it is most commonly obtained from seawater, as every cubic mile of seawater contains around 12 billion pounds of magnesium (in metric units, that's around 1.3 billion kilograms for every cubic kilometer).\n\nSince magnesium burns with a bright white light, it is commonly used in fireworks, flares and photographic flashbulbs. Magnesium is alloyed with aluminum often because it makes aluminum easier to shape. This alloy is used where strong, lightweight materials are required, such as in airplanes, missiles and rockets. Other items made from magnesium alloys include cameras, horseshoes, baseball masks and snowshoes.\n\nIn 1618, in Epsom, England, a farmer discovered hydrated magnesium sulphate (MgSO4 * 7H2O) when his cows refused to drink the water from a mineral well nearby. The farmer tasted the water and found it very bitter, but he also noticed that it helped heal actatches and rashes on his skin. Epsom salt, as the sulphate in the water became known as, is used today for treating minor skin abrasions and injuries. Other mangesium compounds include magnesium carbonate (MgCO3), which is used for making certain types of paints and inks, and magnesium fluoride (MgF2), which is applied to optical lenses to reduce glare and reflections.\n\nMagnesium is an essential element in both plant and animal life. Chlorophyll is a magnesium-centered porphyrin complex, and without magnesium, photosynthesis would not happen and neither will life on Earth. In humans, magnesium is important for hundreds of enzymes to work. The average human body stores about 20 grams of magnesium, mainly in the bones.";
            SetAllText();
        }

        else if (elementSlider.value == 13)
        {
            atomicName = "Aluminum";
            atomicSymbol = "Al";
            atomicMass = 26.9815;
            atomicMelt = 933.437;
            atomicBoil = 2792;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 3;
            atomicGroup = 13;
            atomicDiscoverer = "Hans Oersted";
            atomicYear = 1825;
            atomicIon = 5.986;
            atomicDensity = 2.70;
            atomicIsotopes = 1;
            atomicInfo = "Aluminum, coming from the Latin word for alum, alumen, despite being the most abundant metal in the Earth's crust (about 8.2%), is not found free in nature; you can only find it in compounds. As early as 1787, scientists have suspected that an unknown metal has existed in alum, but they had no way of extracting it until 1825. More years passed with easier and more efficient ways of producing pure aluminum, and after a process that French chemist Henri Etienne Sainte-Claire Deville came up with to improve on German chemist Friedrich Wohler's process, the price of aluminum dropped from about $1200 a kilogram in 1852 to about $40 a kilogram in 1859. However, aluminum still remained too expensive to be used on a widespread basis.\n\nIn the 1880s, two important developments greatly increased the availability of aluminum. The first was a new process of obtaining aluminum from aluminum oxide, developed by American chemist Charles Martin Hall and French chemist Paul L.T. Heroult independently. The second was another process, this time involving the separation of aluminum from bauxite, which is an ore that contains a large amount of aluminum hydroxide (Al2O3 * 3H2O) and other aluminum compounds. This process was developed by Austrian chemist Karl Joseph Bayer in 1888. Both processes are still used to this day for almost all of the world's aluminum. By 1909, about 41,000 kilograms of aluminum was produced a day by the Aluminum Company of America, or Alcoa, resulting in the price of aluminum falling to about $0.60 a kilogram.\n\nToday, aluminum is used in a variety of products, including cans, foils and utensils, and in airplanes, rockets and other things requiring materials that are strong and light. Although it is not as good of an electrical conductor as copper, it is still being used in electrical transmission lines because of its light weight. Aluminum oxide is also used for making synthetic rubies and sapphires for lasers\n\nAluminum has no known role in biology, but aluminum can accumulate in the body, and a link to Alzheimer's disease has been proposed but not yet confirmed nor denied.";
            SetAllText();
        }

        else if (elementSlider.value == 14)
        {
            atomicName = "Silicon";
            atomicSymbol = "Si";
            atomicMass = 28.0855;
            atomicMelt = 1687;
            atomicBoil = 3538;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 3;
            atomicGroup = 14;
            atomicDiscoverer = "Jons Jacob Berzelius";
            atomicYear = 1824;
            atomicIon = 8.152;
            atomicDensity = 2.3296;
            atomicIsotopes = 3;
            atomicInfo = "Silicon, whose name comes from the Latin word for flint, silex, is the seventh most abundant element in the universe and the second most abundant in the Earth's crust. It was first discovered when potassium chips were heated in a silica container and the residual by-products were wiped away afterwards. Today, silicon is produced by heating sand (SiO2) with carbon to temperatures up to 2200 degrees celsius.\n\nThere exist two allotropes of silicon at room temperature: amorphous and crystalline. Amorphous appears as a brown powder while crystalline has a metallic luster and a grayish color. Crystalline silicon crystals can be grown by using the Czochralski process, named after Polish scientist Jan Czochralski. These crystals are used in manufacturing solid-state electronic drives, such as transistors, solar cells, rectifiers and microchips.\n\nSilicon forms many useful compounds with other elements, including silicon carbide (SiC), used as an abrasive, sodium silicate (Na2SiO3), used in the production of soaps and as an egg preservative, and silicon tetrachloride (SiCl4), used to create smoke screens. Silicon is also an important ingredient in silicone, a class of material that is used for lubricants, polishing agents, electrical insulators and medical implants.\n\nSilicon is essential for plant life, but is unknown in animal cells. Silicon is generally non-toxic, but some silicates, such as asbestos, are carcinogenic and some industrial workers can develop a serious lung disease called silicosis if they are exposed to high enough amounts of siliceous dust.";
            SetAllText();
        }

        else if (elementSlider.value == 15)
        {
            atomicName = "Phosphorus";
            atomicSymbol = "P";
            atomicMass = 30.9738;
            atomicMelt = 317.30;
            atomicBoil = 553.65;
            atomicPhase = "Solid";
            atomicClass = "Non-Metal";
            atomicPeriod = 3;
            atomicGroup = 15;
            atomicDiscoverer = "Henning Brandt";
            atomicYear = 1669;
            atomicIon = 10.487;
            atomicDensity = 1.82;
            atomicIsotopes = 1;
            atomicInfo = "Phosphorus, a name that comes from the Greek word phosphoros, meaning \"light bearing\" was discovered in probably the most disgusting method out of all the elements: As many as 60 buckets of urine were boiled, filtered and processed. Gross. Fortunately, phosphorus can now be obtained through phosphate rock (Ca3(PO4)2). Yeah, the less the old method is explained, the better...\n\nThere are three main allotropes of phosphorus: white, red and black. White phosphorus is toxic and can ignite when it comes into contact with air, so it must be stored under water. White phosphorus is usually used to produce phosphorus compounds in factories. Red phosphorus is formed when white phosphorus is either heated to 250 degrees C (482 degrees F) or exposed to direct sunlight. Red phosphorus is not as toxic as white phosphorus, but too much friction could change it back to white phosphorus. Red phosphorus is used in safety matches, fireworks, smoke bombs and pesticides. Black phosphorus is also formed from heating white phosphorus, but a mercury catalyst and a seed crystal of black phosphorus is required to do so. Since black phosphorus is the least reactive of the allotropes, there are no significant commercial uses for it.\n\nPhosphorus compounds are useful in many ways, such as phosphoric acid (H3PO4) in soft drinks and triple superphosphate fertilizer (Ca(H2PO4)2 * H2O) for many plants. Trisodium phosphate (Na3PO4) is used as a cleaning agent and a water softener, while calcium phosphate (Ca3(PO4)2) is used for making china and producing baking powder. Some phosphorus compounds glow in the dark or emit light in response to absorbing radiation and are therefore used in fluorescent light bulbs and television sets.\n\nPhosphorus is essential for all living things because it forms the sugar-phosphate backbone of DNA and RNA. It is essential for the transfer of energy in cells as part of ATP (adenosine triphosphate) and for other biologically important molecules. Humans take in about 1 gram of phosphate a day and store about 750 grams in our bodies, since our bones and teeth consist mostly of calcium phosphate.";
            SetAllText();
        }

        else if (elementSlider.value == 16)
        {
            atomicName = "Sulfur";
            atomicSymbol = "S";
            atomicMass = 32.066;
            atomicMelt = 388.36;
            atomicBoil = 717.75;
            atomicPhase = "Solid";
            atomicClass = "Non-Metal";
            atomicPeriod = 3;
            atomicGroup = 16;
            atomicDiscoverer = "N/A";
            atomicYear = 0;
            atomicIon = 10.360;
            atomicDensity = 2.067;
            atomicIsotopes = 4;
            atomicInfo = "Sulfur, whose name comes from the Sanskrit word sulvere and the Latin word sulphurium, is the tenth most abundant element in the known universe, and has been known by humans since ancient times. Sulfur compounds with many other elements to form minerals such as galena (PbS), gypsum (CaSO4 * 2H2O), pyrite (FeS2), cinnabar (HgS), celestite (SrSO4) and barite (BaSO4). About a quarter of all sulfur produced today is recovered from petroleum refining operations and as a byproduct of extracting other materials from ores that contain sulfur. Most of the sulfur produced today comes from underground deposits found near most salt deposits.\n\nSulfur has three allotropic forms: orthorhrombic, monoclinic and amorphous. The othorhombic form is the most stable of the three sulfur allotropes. Monoclinic sulfur only exists when its temperature is between 96C and 119C and reverts back to orthorhombic form when cooled. Amorphous sulfur forms when molten sulfur is quickly cooled, but it eventually reverts back to orthorhombic form after some time.\n\nMost of the sulfur that is produced today is used in the manufacture of sulfuric acid (H2SO4). Almost 40 million tons of sulfuric acid is used to make lead-acid batteries, fertilizers and for many industrial processes each year. Smaller amounts of sulfuric acid are used to vulcanize natural rubbers and manufacture gunpowder. Did you know that the Greek poet Homer mentioned \"pest-averting sulphur\" nearly 2,800 years ago? That might explain sulfuric acid's use in many different pesticides as well.\n\nIn addition to sulfuric acid and the minerals mentioned earlier, sulfur forms other interesting compounds with other elements. These compounds include hydrogen sulfide (H2S), a gas that smells like rotten eggs, sulfur dioxide (SO2) which forms when sulfur is burned in the air and is used as a bleaching agent, a solvent, a disinfectant and a refrigerant, and sulfurous acid (H2SO3), a major component of acid rain, despite being a weak acid.";
            SetAllText();
        }

        else if (elementSlider.value == 17)
        {
            atomicName = "Chlorine";
            atomicSymbol = "Cl";
            atomicMass = 35.4527;
            atomicMelt = 171.65;
            atomicBoil = 239.11;
            atomicPhase = "Gas";
            atomicClass = "Halogen";
            atomicPeriod = 3;
            atomicGroup = 17;
            atomicDiscoverer = "Carl Wilhelm Scheele";
            atomicYear = 1774;
            atomicIon = 12.968;
            atomicDensity = 0.0032;
            atomicIsotopes = 2;
            atomicInfo = "Chlorine, coming from the Greek word chloros, meaning \"greenish yellow,\" reacts with nearly every other element, so it can not be found pure in nature. Chlorine was first produced when the mineral pyrolusite (MnO2) with hydrochloric acid (HCl), but it wasn't recognized as an element until 1810, when Sir Humphry Davy proved that it was. Today, most chlorine is produced through the electrolysis of sodium chloride (NaCl), also known as table salt.\n\nChlorine is commonly used as an antiseptic to kill off organisms that may reside in drinking water and swimming pools. In larger amounts, it is used in many industrial processes, including the production of paper products, plastics, textiles, medicines, insecticides and paints. In the past, chlorine was used to make an anaesthetic called chloroform (CHCl3) and a dry-cleaning solvent known as carbon tetrachloride (CCl4), but they are both now strictly controlled due to their potential to cause liver damage.\n\nChlorine is a very dangerous element. It can irritate the mucus membranes if inhaled in high enough amounts. In liquid form, it burns skin immediately on contact. So dangerous is chlorine, in fact, that during World War I, it was used as a chemical weapon by the Germans starting on April 22, 1915. This new weapon shocked Allied soldiers along the western front and forced them to fall back. The chlorine gas wafted across the battlefield and into Allied trenches. In total that day, over 150 tons of chlorine was used by the Germans and the Allied line was nearly devastated.\n\nDespite chlorine's potential to kill several organisms because of how deadly it is in its pure form, in compounds, it is typically much safer and more useful. Chloride ions are mostly present in cell fluid as a negative ion to balance the positive potassium ions. It is also present in extra-cellular fluids (e.g. blood) to balance the positive sodium ions. Most of the chloride that we get is from table salt that we sprinkle on some foods for flavor.";
            SetAllText();
        }

        else if (elementSlider.value == 18)
        {
            atomicName = "Argon";
            atomicSymbol = "Ar";
            atomicMass = 39.948;
            atomicMelt = 83.80;
            atomicBoil = 87.30;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 3;
            atomicGroup = 18;
            atomicDiscoverer = "Lord Rayleigh and Sir William Ramsey";
            atomicYear = 1894;
            atomicIon = 15.760;
            atomicDensity = 0.0018;
            atomicIsotopes = 3;
            atomicInfo = "Argon, a name deriving from the Greek word for inactive, argos, is the third most abundant gas in the Earth's atmosphere, making 0.93% of its composition. Argon can be obtained from the air as a byproduct of oxygen and nitrogen.\n\nSince argon is an inert gas, like helium and neon, it does not form compounds with many other elements. However, it was reported in August of 2000 that a compound of argon fluorohydride (HArF) was synthesized. The reported compound is stable only at very low temperatures, with it starting to decompose once it goes above -246C, so it has no practical uses outside of scientific research. By itself, argon is used when an inert atmosphere is needed for producing titanium and other reactive elements. It is also used by welders to protect the weld area and inincandescent light bulbs to stop oxygen from corroding the filament inside. Many double-glazed windows use argon to fill the space betwen the panes, and the tires of luxury cars have argon in them to protect the rubber and reduce road noise.";
            SetAllText();
        }

        else if (elementSlider.value == 19)
        {
            atomicName = "Potassium";
            atomicSymbol = "K";
            atomicMass = 39.0983;
            atomicMelt = 336.53;
            atomicBoil = 1032;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 4;
            atomicGroup = 1;
            atomicDiscoverer = "Humphry Davy";
            atomicYear = 1807;
            atomicIon = 4.341;
            atomicDensity = 0.89;
            atomicIsotopes = 2;
            atomicInfo = "Potassium's name comes from the English word potash, but its chemical symbol comes from the Latin word for alkali, kalium.\n\nPotassium makes up about 2.1% of the Earth's crust but is never found free in nature because it is very reactive. Potassium was first obtained through the electrolysis of caustic potash (KOH), but today it can be found through the minerals sylvite (KCl), caranallite (KCl * MgCl2 * 6H2O) and polyhalite (K2Ca2Mg(SO4)4 * 2H2O). These minerals can be found in ancient lake and sea beds. Another source of potassium is caustic potash, which is mined primarily in Germany, New Mexico, California and Utah.\n\nPure potassium is a soft, waxy metal that is easily cut with a knife. It reacts with oxygen to form potassium superoxide (PO2) and water to form potassium hydroxide (KOH). To prevent the potassium from reacting with the oxygen and water in the air, pure potassium is usually stored under mineral oil\n\nAs an alloy with sodium, potassium is used in heat transfer in some types of nuclear reactors. It forms a compound with chlorine to form potassium chloride (KCl), used in fertilisers, as salt substitutes and to produce other chemicals. It compounds with hydrogen, carbon and oxygen to form potassium carbonate (KHCO3), or pearl ash, to make certain types of glass and soaps. Potassium superoxide creates oxygen from water vapor (H2O) and carbon dioxide (CO2), so it is used in respiratory equipment. Potassium nitrate (KNO3) is used in match heads and pyrotechnic equipment.\n\nPotassium is an essential element to life. Potassium ions are present in all cells because it helps maintain fluid and electrolyte balance. Plant cells are particularly rich in potassium, which they get mainly from the soil. On average, humans consume about 7 grams of potassium a day and store around 140 grams in body cells. The isotope potassium-40 is mildly radioactive and it might be a natural cause of genetic mutation in humans.";
            SetAllText();
        }

        else if (elementSlider.value == 20)
        {
            atomicName = "Calcium";
            atomicSymbol = "Ca";
            atomicMass = 40.078;
            atomicMelt = 1115;
            atomicBoil = 1757;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 4;
            atomicGroup = 2;
            atomicDiscoverer = "Sir Humphry Davy";
            atomicYear = 1808;
            atomicIon = 6.113;
            atomicDensity = 1.54;
            atomicIsotopes = 3;
            atomicInfo = "Calcium, whose name is from the Latin word for lime, calx, is the fifth most abundant element in the Earth's crust, but since it easily forms compounds with oxygen and water, it is never found free in nature. Pure calcium was first obtained through the electrolysis of lime (CaO) and mercuric oxide (HgO). Today, it is done through displacing calcium atoms in lime with atoms of aluminum in hot, low-pressure containers, but since it is highly reactive, demand for metallic calcium is very low. However, pure calcium is used for come chemical processes for refining thorium, uranium and zirconium, and it removes oxygen, sulfur and carbon from certain alloys.\n\nCalcium carbonate (CaCO3) is one common compound of calcium. It is heated to form quicklime (CaO), which is then added to water to form a material known as slaked lime (Ca(OH)2), an inexpensive base material used in the chemical industry. Calcium carbonate is used to make white paint, cleaning powder, toothpaste, stomach acids and other products. Chalk, marble and limestone are all forms of calcium carbonate.\n\nOther common compounds of calcium include caclium sulfate (CaSO4), used for making dry wall and plaster of Paris, calcium nitrate (Ca(NO3)2), a naturally occurring fertilizer, and calcium phosphate (Ca3(PO4)2), found inside our bodies as what mostly makes up our bones and teeth.\n\nBecause calcium phosphate is the primary component of teeth and bones, it is highly encouraged that children and pregnant women eat foods rich in calcium, such as milk and other dairy products, leafy green vegetables and fish.";
            SetAllText();
        }

        else if (elementSlider.value == 21)
        {
            atomicName = "Scandium";
            atomicSymbol = "Sc";
            atomicMass = 44.9559;
            atomicMelt = 1814;
            atomicBoil = 3109;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 3;
            atomicDiscoverer = "Lars Frederik Nilson";
            atomicYear = 1879;
            atomicIon = 6.561;
            atomicDensity = 2.99;
            atomicIsotopes = 1;
            atomicInfo = "Scandium, named after Scandinavia in northeastern Europe, was first discovered when an attempt was made to produce a sample of pure ytterbia from 10 kilograms of the mineral euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, It)2)6). Today, scandium can be obtined from the minerals thortveitite ((Sc, Y)2Si2O7), bazzite (Be3(Sc, Al)2Si6O18) and wiikite, but it is usually obtained a byproduct of refining uranium.\n\nThe first metallic scandium was produced in 1937 while the first pure scandium was produced in 1960. Because it costs about $270 per gram, adding up to $122,500 per pound, scandium is too expensive to be used for widespread use. Alloys of scandium and aluminum are used in some pieces of athletic equipment, such as aluminum baseball bats, bicycle frames and lacrosse sticks. Scandium-aluminum alloys may potentially become important in manufacturing fuel cells.\n\nScientists have not studied many compounds of scandium, but one compound, scandium oxide (Sc2O3), also called scandia, is used in the United States to produce high intensity lights. Another compound, scandum iodide (ScI3), is added to mercury vapor lamps so that they will emit light that is almost like sunlight. A radioactive isotope of scandium, scandium-46, is used as a tracer in oil refining to monitor the movement of various fractions and in underground pipes to detect leaks.\n\nScandium has no known role in biology and is actually a suspected carcinogen.";
            SetAllText();
        }

        else if (elementSlider.value == 22)
        {
            atomicName = "Titanium";
            atomicSymbol = "Ti";
            atomicMass = 47.867;
            atomicMelt = 1941;
            atomicBoil = 3560;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 4;
            atomicDiscoverer = "William Gregor";
            atomicYear = 1791;
            atomicIon = 6.828;
            atomicDensity = 4.5;
            atomicIsotopes = 5;
            atomicInfo = "Titanium, from the Greek word Titans, the mythological \"first sons of Earth\" is the ninth most abundant element in the Earth's crust (about 0.57% of its composition) and is found primarily in the minerals rutile (TiO2), ilmenite (FeTiO3) and sphene (CaTiSiO5).\n\nTitanium is stronger than steel and aluminum, but is lighter than steel and heavier than aluminum. It is not easily corroded with sea water, so it is used in propeller shafts, rigging and other parts of boats that are exposed to water. Titanium and alloys containing titanium are used in airplanes, missiles and rockets where strength, low weight and resistance to high temperatures is very important. Titanium does not react to the human body, so it is used to make artificial hips. However, titanium is very expensive, so its widespread use is limited.\n\nThe compound titanium oxide (TiO2) is used as a pigment to create white paint, which is the largest use of the element. In titanium oxide's pure form, it is used for creating titania, an artificial gemstone used in jewelry. Another compound of titanium, titanium tetrachloride (TiCl4), is used to make smoke screens.\n\nThere are no known biological roles for titanium, but the human body can tolerate titanium in large doses because it is non-toxic. However, in a metallic powdered form, it can pose a significant fire and explosion hazard as well if it is heated in the air.";
            SetAllText();
        }

        else if (elementSlider.value == 23)
        {
            atomicName = "Vanadium";
            atomicSymbol = "V";
            atomicMass = 50.9415;
            atomicMelt = 2183;
            atomicBoil = 3680;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 5;
            atomicDiscoverer = "Andres Manuel del Rio";
            atomicYear = 1801;
            atomicIon = 6.746;
            atomicDensity = 6.0;
            atomicIsotopes = 1;
            atomicInfo = "Vanadium, named after the Scandinavian god Vanadis, was first isolated by English Chemist Sir Henry Enfield Roscoe in 1867 by combining vanadium trichloride (VCl3) eith hydrogen gas. Today's methods of obtaining vanadium is from the minerals vanadinite (Pb5(VO)3Cl) and carnotite (K2(UO2)2VO4 * 1-3H2O) by heating crushed ore while with carbon and chlorine to produce vanadium chloride. It is then heated with magnesium in an atmosphere of argon.\n\nVanadium is resistant to corrosion, so it is sometimes used to make special pipes and tubes for the chemical industry. Vanadium also does not absorb neutrons easily, so it has some uses in the nuclear power industry. A thin layer of vanadium id applied to titanium and steel to bond them together. Almost 80% of all vanadium that is produced is used to make ferrovanadium, which is a strong, shock resistant and corrosion resistant alloy of iron that contains about 1% to 6% vanadium. Ferrovanadium and vanadium-steel alloys are used to make axles and crankshafts for cars, jet engine parts and many cutting tools.\n\nAlthough humans need very little vanadium in their bodies each day (about 0.01 milligrams), vanadium is essential for some other species of animals, but it can become toxic in some compounds.";
            SetAllText();
        }

        else if (elementSlider.value == 24)
        {
            atomicName = "Chromium";
            atomicSymbol = "Cr";
            atomicMass = 51.9961;
            atomicMelt = 2180;
            atomicBoil = 2944;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 6;
            atomicDiscoverer = "Nicholas Louis Vauquelin";
            atomicYear = 1798;
            atomicIon = 6.767;
            atomicDensity = 7.15;
            atomicIsotopes = 3;
            atomicInfo = "Chromium, whose name is from the Greek word for color, chroma, was first isolated when chromium oxide (CrO3) was heated in a charcoal oven. It can be obtained today by heating the mineral chromite (FeCr3O4) while in the presence of either aluminum or silicon.\n\nChromium is a very hard, brittle and corrosion resistant metal, so it is often added to steel to harden it and form stainless steel in the process. Stainless steel is a steel alloy that contains about 10% chromium. There are other chromium-steel alloys that are used to make armor plating, safes, ball bearings and cutting tools.\n\nChromium forms several colorful compounds that give color to several things. For example, lead chromate (PbCrO4), also known as chrome yellow, is used as a yellow pigment in paints, chromic oxide (Cr2O3), also known as chrome green, is used as a green pigment in paints, and rubies and emeralds also owe their colors to chromium compounds. Industrial uses for chromium compounds include anodizing aluminum by coating it with a think protective layer of oxide and making molds with chromite for firing bricks.\n\nPeople can be exposed to chromium and its compounds through breathing, eating, drinking, or skin contact. The level of chromium in our air is typically low, and so is the level usually in drinking water, but contaminated well water may contain chromium(IV), which is dangerous and can cause respiratory problems, weakened immune systems and alteration of genetic material if you are exposed to it in high amounts. The less dangerous chromium(III) is an essential nutrient for humans and is the main route for chromium uptake. Chromium(III) occurs naturally in many fruits, vegetables, meats, yeasts and grains. A shortage of chromium(III) may cause heart problems, metabolism disruptions and diabetes, but too much chromium(III) can cause health problems, too, but it's mostly just skin rashes.";
            SetAllText();
        }

        else if (elementSlider.value == 25)
        {
            atomicName = "Manganese";
            atomicSymbol = "Mn";
            atomicMass = 54.938;
            atomicMelt = 1519;
            atomicBoil = 2334;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 7;
            atomicDiscoverer = "Johan Gottlieb Gahn";
            atomicYear = 1774;
            atomicIon = 7.434;
            atomicDensity = 7.3;
            atomicIsotopes = 1;
            atomicInfo = "Manganese, coming from magnes, the Latin word for magnet, was first produced by heating the mineral pyrolusite (MnO2) in the presence of charcoal, whereas today's methods include burning pyrolusite in a furnace with powdered aluminum or treating it with sulfuric acid (H2SO4) to form manganese sulfate (MnSO4), which is then electrolyzed to separate the elements.\n\nAlmost 90% of all manganese produced each year is used for producing steel, where it is either added to molten steel to remove oxygen and sulfur or is alloyed with steel to to make it easier to form and work with and to increase the steel's strength and impact resistance. Manganese is also used to give glass an amethyst color for use in gemstones.\n\nManganese dioxide (MnO2), the most common compound of manganese, makes up around 0.14% of the Earth's crust. It is used inside dry cell batteries to prevent hydrogen from being formed, to remove the green color in glass caused by iron contaminants and as a drying agent in black paints.\n\nManganese is an essential element in all known living organisms because most types of enzymes contain manganese. Some soils have low manganese so it is added to some fertilizers and given to some grazing animals as a food supplement. On average, human bodies have about 12 milligrams of manganese and take in about 4 milligrams a day from our food. Without it, bones would grow spongier and become more fragile.";
            SetAllText();
        }

        else if (elementSlider.value == 26)
        {
            atomicName = "Iron";
            atomicSymbol = "Fe";
            atomicMass = 55.845;
            atomicMelt = 1811;
            atomicBoil = 3134;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 8;
            atomicDiscoverer = "N/A";
            atomicYear = -3500;
            atomicIon = 7.902;
            atomicDensity = 7.874;
            atomicIsotopes = 4;
            atomicInfo = "Iron has a name that comes from the Anglo-Saxon word iron, but its chemical symbol comes from the Latin word for iron, ferrum.\n\nAccording to archaeological evidence, iron has been used by humans for more than 5,000 years. It is the cheapest and most abundant of all metals, comprising almost 5.6% of the Earth's crust and almost all of the Earth's core. Iron is obtained through the minerals hematite (Fe2O3), magnetite (Fe3O4), limonite (FeO(OH) * nH2O) and siderite (FeCO3).\n\nLarge amounts of iron are used to make steel, an alloy of iron and carbon. Steel consists of between 0.3% and 1.5% carbon, depending on the requirements by steel manufacturers. Other elements can be included in steel to five it other useful properties. For example, chromium improves durability and prevents rust (making it stainless steel), nickel increases resistance to heat and many acids, manganese increases resistance to wear, tungsten retains hardness at high temperatures and vandanium increases springiness. Steel is commonly used to make paperclips, skyscrapers and probably everything else you can think of in between. What a useful material steel is!\n\nAside from its usefulness in the steel industry, iron is essential for all forms of life and is non-toxic in small amounts. Most of the iron in human bodies is in hemoglobin, which is in the blood. Hemoglobin carries oxygen from our lungs to our cells, where it is needed for tissue respiration. A man must consume seven milligrams of iron per day and a woman eleven milligrams. If we don't get the iron that we need, it may lead to iron deficiency, which causes anemia. Fortunately, the compound iron sulfate (FeSO4) is used to treat anemia.\n\n(Note: Any element's discovery year that has a minus sign before it means that the element was discovered in or around that year, BC.)";
            SetAllText();
        }

        else if (elementSlider.value == 27)
        {
            atomicName = "Cobalt";
            atomicSymbol = "Co";
            atomicMass = 58.9332;
            atomicMelt = 1768;
            atomicBoil = 3200;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 9;
            atomicDiscoverer = "Georg Brandt";
            atomicYear = 1739;
            atomicIon = 7.881;
            atomicDensity = 8.86;
            atomicIsotopes = 1;
            atomicInfo = "Cobalt, a name coming from the German word for goblin or evil spirit, kobald, and the Greek word for mine, cobalos, was discovered when attempts were made to prove that the ability to color glass blue was the work of an unknown element. At the time of its discovery, it was believed to be bismuth causing this color, but that turned out to not be the case. Cobalt is obtained as a byproduct of mining and refining nickel, silver, lead, copper and iron. Cobalt's primary ores are cobaltite (CoAsS) and erythrite(Co3(AsO4)2).\n\nOne of cobalt's uses is for electroplating to give objects an attractive surface that resists oxidation. In alnico, an alloy made of aluminum, nickel and cobalt, it can make powerful permanent magnets. In stellite, an alloy of cobalt, chromium and tungsten, it makes high-speed and high-temperature cutting tools and dyes. Cobalt makes other alloys for jet engines, gas turbines, magnetic steels and some stainless steel types.\n\nCobalt has been used for centuries in coloring porcelain, glass, pottery, tile and enamel. The compounds that give them the colors are known as: cobalt blue, ceruleum, new blue, smalt, cobalt yellow and cobalt green. Cobalt is also an essential part of vitamin B12 in human nutrition.\n\nCobalt-60 is a radioactive isotope of cobalt. It is a very important source of gamma rays and is used to treat many types of cancer in patients and as a medical tracer. Cobalt-60 is also used for preserving food and making it safer for customers. Cobalt-60 has a half-life of 5.27 years and decays into nickel-60 through beta-minus decay, where one of the neutrons in a radioactive atom's nucleus truns into a proton, an electron and an antineutrino.\n\n(Note: A half-life is the time it takes for half of a radioactive substance to decay. For example, as stated earlier, cobalt-60 has a half-life of 5.27 years, so in 5.27 years, or 1 half-life of cobalt-60, half of it will turn into nickel-60, and in another 5.27 years, or after 2 half-lives of cobalt-60, half of what did not turn into nickel-60 will do so, leaving 1/4 of the initial amount of cobalt-60 remaining. After 3 half-lives, 1/8 of the initial amout remains. After 4 half lives, 1/16 remains. After 5 half-lives, 1/32, and so on.)";
            SetAllText();
        }

        else if (elementSlider.value == 28)
        {
            atomicName = "Nickel";
            atomicSymbol = "Ni";
            atomicMass = 58.6934;
            atomicMelt = 1728;
            atomicBoil = 3186;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 10;
            atomicDiscoverer = "Axel Fredrik Cronstedt";
            atomicYear = 1751;
            atomicIon = 7.64;
            atomicDensity = 8.912;
            atomicIsotopes = 5;
            atomicInfo = "Nickel, whose name mainly comes from the German word Nickel, which means \"Old Nick,\" a name for the devil, was first discovered within the mineral niccolite (NiAs). Most of the world's nickel supply comes from the Sudbury region of Ontario, Canada. It is believed that the large nickel deposit there was caused by a meteor impact in ancient times.\n\nNickel can be electroplated onto other metals to form a protective coating. Finely divided nickel is used as a catalyst for hydrogenating vegetable oils. Nickel gives glass a green color. Nickel is used in rechargeabe nickel-cadmium batteries and nickel-metal hydride batteries used in hybrid vehicles. One gram of nickel can make 300 kilometers (roughly 186 miles) of wire. Nickel has a long history of being used in coins, most notably the US five-cent piece of the same name, which consists of 25% nickel and 75% copper.\n\nNickel is alloyed with other elements to improve their strength and corrosion resistance. With steel, nickel is used to make armor plate, vaults and machine parts. It is also alloyed with copper to make pipes that are used in desalination plants. Nickel is part of alnico, an alloy used to make very powerful permanent magnets.\n\nThere are no known roles of nickel in biology, but it has been known to be beneficial to certain species. We take in nickel compounds with the food we eat. Nickel is an essential element in navy beans used for baked beans. Too much nickel, however, could result in higher chances of certain cancers, lung embolism, respiratory failure and in more severe cases of excess uptake, heart disorders.";
            SetAllText();
        }

        else if (elementSlider.value == 29)
        {
            atomicName = "Copper";
            atomicSymbol = "Cu";
            atomicMass = 63.546;
            atomicMelt = 1357.77;
            atomicBoil = 2835;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 11;
            atomicDiscoverer = "N/A";
            atomicYear = 0;
            atomicIon = 7.726;
            atomicDensity = 8.933;
            atomicIsotopes = 2;
            atomicInfo = "Copper, whose name comes from the Latin word cuprum, which means \"from the island of Cyprus,\" has been used by humans for at least 11,000 years, according to archaeological evidence. It was easy to obtain and refine because beople have developed copper extracting methods that date back at least 7,000 years. During the time of the Roman Empire, most of its copper came from the island of Cyprus. Today, copper can be obtained from ore deposits located in the United States, Canada, Chile, Zambia, Zaire and Peru. Some of the main ores that copper is found in are cuprite (CuO2), tenorite (CuO), malachite (CuO3 * Cu(OH)2) and covellite (CuS).\n\nStarting around 5,000 years ago, people learned that pure copper was too soft for most uses, but it could be alloyed to make it stronger. The two most familiar copper alloys are bronze and brass. Bronze, the first alloy created by people, contains as much as 25% tin. The earliest uses for bronze were for tools, weaponry, containers and decorative items. Brass is a copper alloy that contains anywhere between about 5% and 45% zinc. Brass was first used about 2,500 years ago by the Romans to make coins, kettles and ornaments. Today, brass is used in some musical instruments, screws and other hardware that must be corrosion resistant.\n\nCopper today is mostly used for electrical equipment, such as wiring and motors, because it is a good conductor of both heat and electricity. In construction, copper is used to make roofing and plumbine materials. In the compound copper sulfate (CuSO4 * H2O), also called blue vitriol, is used as an agricultural poison, an algicide for water purification and a blue pigment for inks. Copper chloride (CuCl2), another copper compound, is used to fix dyes to fabrics. Cuprous chloride (CuCl) is a poisonous white powder used for absorbing carbon dioxide (CO2). Copper cyanide (CuCN) is used often for electroplating.\n\nCopper is an essential element for the human body because it helps enzymes trasfer energy in cells, but in excess, copper is toxic.";
            SetAllText();
        }

        else if (elementSlider.value == 30)
        {
            atomicName = "Zinc";
            atomicSymbol = "Zn";
            atomicMass = 65.38;
            atomicMelt = 692.68;
            atomicBoil = 1180;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 12;
            atomicDiscoverer = "Andreas Marggraf";
            atomicYear = 1746;
            atomicIon = 9.394;
            atomicDensity = 7.134;
            atomicIsotopes = 3;
            atomicInfo = "Zinc, a name coming from the German word zink, has been used for at least 2,500 years for producing brass, but it was not recognized as an element until much later. Metallic zinc was first produced in the 1400s in India by using wool to heat the mineral calamine (ZnCO3). It was later produced by heating calamine with charcoal. Most of today's zinc is produced through the electrolysis of aqueous zinc sulfate (ZnSO4).\n\nAbout a third of all metallic zinc is produced through a process called galvinization, in which something that is subject to corrosion, such as an iron nail, is given a protective zinc coating. The coating is applied either by dipping it in a pool of molten zinc or most commonly by electroplating. Metallic zinc is used for making dry cell batteries, roof cladding and die castings.\n\nZinc is also used to make several useful alloys. For example, brass, an alloy of zinc containing between 55% and 95% copper, was first used about 2,500 years ago by the Romans to make coins, kettles and ornamental items. Brass is widely used today for making musical instruments, screws and other corrosion resistant hardware. Soldier, an alloy containing zinc, lead and tin, has a relatively low melting point and is used for joining electrical components, pipes and other items. Nickel silver, typewriter metal, spring brass and German silver are other examples of zinc alloys.\n\nZinc oxide (ZnO), a common compound of zinc, is formed when metallic zinc is exposed to the air and forms a coating that protects the rest of the metal. Zinc oxide is used in paints, certain rubber products, cosmetics, pharmaceuticals, plastics, printing inks, soap, batteries and many other things. Zinc sulfide (ZnS), another compound containing zinc, glows when it is exposed to ultraviolet light, X-rays, or electrons and is therefore used to make luminous watch dials, TV screens and fluorescent light bulbs. Zinc chloride (ZnCl2) protects wood from decay and insects.\n\nZinc is essential for all known living things because it forms the active site in over 20 metallo-enzymes. On average, the human body has about 2.5 grams of zinc and takes in about 15 milligrams a day. Most of the zinc we take in comes from beef, sunflower seeds and cheese. In excess, however, zinc can be carcinogenic because if newly formed zinc oxide is inhaled, a disorder called the 'oxide shakes' or 'zinc chills' can happen.";
            SetAllText();
        }

        else if (elementSlider.value == 31)
        {
            atomicName = "Gallium";
            atomicSymbol = "Ga";
            atomicMass = 69.723;
            atomicMelt = 302.91;
            atomicBoil = 2477;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 4;
            atomicGroup = 13;
            atomicDiscoverer = "Paul-Emile Lecoq de Boisbaudran";
            atomicYear = 1875;
            atomicIon = 5.999;
            atomicDensity = 5.91;
            atomicIsotopes = 2;
            atomicInfo = "Gallium, an element whose name comes from Gallia, which is \"France\" in Latin, was first proposed to exist by Dimitri Mendeleyev in 1871 based on gaps in his Periodic Table of the Elements, which was newly created at the time. Pure gallium was first obtained when a solution of the compound gallium hydroxide (Ga(OH3) in potassium hydroxide (KOH) was electrolyzed. Today's methods of obtaining gallium involve extracting it from diaspore, sphalerite, germanite and bauxite, and it comes as a byproduct of burning coal.\n\nGallium melts when it is near room temperature and has one of the largest ranges of any metal, so it is used often in high temperature thermometers. Gallium is also used as a doping material for semiconductors and to produce solid-state items such as transistors and light emitting diodes. Gallium arsenide (GaAs), another compound of gallium, can produce a laser light directly from electricity. The Gallium Neutrino Observatory in Italy is made of large amounts of gallium trichloride (GaCl3).\n\nGallium has no known role in biology, but it does occur inside the human body in small amounts. Although it is non-toxic generally, gallium should not be intentionally consumed in large doses.";
            SetAllText();
        }

        else if (elementSlider.value == 32)
        {
            atomicName = "Germanium";
            atomicSymbol = "Ge";
            atomicMass = 72.630;
            atomicMelt = 1211.4;
            atomicBoil = 3106;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 4;
            atomicGroup = 14;
            atomicDiscoverer = "Clemens Winkler";
            atomicYear = 1886;
            atomicIon = 7.9;
            atomicDensity = 5.323;
            atomicIsotopes = 5;
            atomicInfo = "Germanium, named after the country of Germany, is another element that was first proposed to exist by Dimiti Mendeleyev in 1871 based on gaps in his Periodic Table. It was later discovered in the mineral argyrodite (Ag8GeS6), confirming Mendeleyev's proposal. Garmanium is produced today by smelting zinc ores and burning certain types of coal.\n\nGermanium's largest use is in the semiconductor industry, where it is doped with small amounts of arsenic, gallium, indium, antimony, or phosphorus to make transistors for electronic devices. Germanium and germanium oxide (GeO) are transparent to infrared radiationand is therefore used in infrared optical instruments and detectors. There are some germanium compounds that are useful in killing bacteria and are being studied for possible use in chemotherapy.\n\nGermanium doesn't have any known biologic uses, but its estimated daily intake by humans is 1 milligram, and there have been claims that germanium could be beneficial to health, though there is no scientific proof of this.";
            SetAllText();
        }

        else if (elementSlider.value == 33)
        {
            atomicName = "Arsenic";
            atomicSymbol = "As";
            atomicMass = 74.9216;
            atomicMelt = 889;
            atomicBoil = 889;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 4;
            atomicGroup = 15;
            atomicDiscoverer = "Albertus Magnus";
            atomicYear = 1250;
            atomicIon = 9.815;
            atomicDensity = 5.776;
            atomicIsotopes = 1;
            atomicInfo = "Arsenic's name comes from the Latin word arsenicum, the Greek word arsenikon and the Arabic word Az-zernikh, and its compounds were mined by early Chinese, Greek and Egyptian civilizations. It occurs free in nature but mostly resided in the minerals arsenopyrire (FeAsS), realgar (AsS) and orpiment. It is obtained today by heating arsenopyrite.\n\nArsenic is one of the most toxic elements on the Periodic Table. Because of how dangerous arsenic is, it is used to make rat poison and some insecticides. When added to gallium, it can make electrical transistors, and when it is compounded with gallium, it produces laser light directly from electricity.\n\nIf you have seen that arsenic's melting and boiling points are the same here, it's not you. They are the same because when arsenic is heated at a standard atmospheric pressure, arsenic changes from a solid directly into a gas. To gel liquid arsenic you would have to increase the atmospheric pressure to about 28 times normal. At this pressure, arsenic's meltng point would be 1090 K and its boiling point would be much higher.";
            SetAllText();
        }

        else if (elementSlider.value == 34)
        {
            atomicName = "Selenium";
            atomicSymbol = "Se";
            atomicMass = 78.971;
            atomicMelt = 493.65;
            atomicBoil = 958;
            atomicPhase = "Solid";
            atomicClass = "Non-Metal";
            atomicPeriod = 4;
            atomicGroup = 16;
            atomicDiscoverer = "Jons Jacob Berzelius";
            atomicYear = 1817;
            atomicIon = 9.752;
            atomicDensity = 4.809;
            atomicIsotopes = 6;
            atomicInfo = "Selenium, named for the Greek word for moon, selene, was discovered when an impurity was detected in some sulfuric acid (H2SO4) that was produced in a factory in Sweden. The impurity was originally thought to be tellurium, but after some analysis, it turned out to be selenium, which was an unknown element at the time. Selenium can be found in nature as part of the minerals eucairite (CuAgSe), crooksite (CuThSe) and clausthalite (PbSe), but they are too rare to be used as major sources of selenium. Most of today's selenium is produced as a byproduct of refining copper from ores.\n\nSelenium's resistance to electricity, believe it or not, depends a lot on how much light is shining on it. The brighter the light is, the better selenium's conductivity. As a result, selenium is used in devices that respond to the intensity of light, such as electric eyes, photo cells, light meters for cameras and photo copiers. Selenium can also produce electricity from sunlight and is therefore used in solar cells. In addition to being used in electrical devices, selenium is also used to make the ruby-red color in glasses and enamels, as a photographic toner and as a stainless steel additive.\n\nSelenium does not form many inorganic compounds, and none of them are commercially important. These compounds include selenious acid (H2SeO3), selenium dichloride (SeCl2) and selenium oxychloride (SeOCl2).\n\nIn biology, selenium is an essential trace element. Human bodies contain around 14 milligrams of selenium and every cell contains more than a million selenium atoms. Too little selenium can cause health problems, but too much selenium can be carcinogenic and teratogenic, meaning that it can disturb the development of an embryo or fetus.";
            SetAllText();
        }

        else if (elementSlider.value == 35)
        {
            atomicName = "Bromine";
            atomicSymbol = "Br";
            atomicMass = 79.904;
            atomicMelt = 265.95;
            atomicBoil = 331.95;
            atomicPhase = "Liquid";
            atomicClass = "Halogen";
            atomicPeriod = 4;
            atomicGroup = 17;
            atomicDiscoverer = "Antoine-Jerome Balard and Carl Lowig";
            atomicYear = 1826;
            atomicIon = 11.814;
            atomicDensity = 3.11;
            atomicIsotopes = 2;
            atomicInfo = "Bromine, who gets its name from the Greek word for stench, bromos, is one of only two elements at all on the Periodic Table that is a liquid at room temperature, the other being mercury. Today's methods of obtaining bromine involves treating brines from wells in Michigan and Arkansas with chlorine.\n\nIn the old days, most of the bromine that is produced in the United States was used in the making of ethylene dibromide (C2H4Br2) to prevent lead accumulation in engines, but its demand decreased sharply due to the abolishment of leaded fuels in favor of unleaded gasoline. Silver bromide (AgBr), a chemical used for photography, is the largest use for bromine today. Other bromine compounds are used in flameproofing agents and sometimes to purify water. Tyrian purple, an expensive purple dye known to ancient times, was produced from an organic bromine compound obtained from a type of sea mussel known as the murex.\n\nWhile bromine is present in small amounts in all living things, it has no known biological role in humans. Bromine is a hazardous element and causes severe burns to the skin on contact and can irritate the eyes, nose and throat.";
            SetAllText();
        }

        else if (elementSlider.value == 36)
        {
            atomicName = "Krypton";
            atomicSymbol = "Kr";
            atomicMass = 83.798;
            atomicMelt = 115.79;
            atomicBoil = 119.93;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 4;
            atomicGroup = 18;
            atomicDiscoverer = "Sir William Ramsey and Morris M. Travers";
            atomicYear = 1898;
            atomicIon = 14.000;
            atomicDensity = 0.0037;
            atomicIsotopes = 5;
            atomicInfo = "Krypton, whose name comes from the Greek word for hidden, kryptos, was discovered while Ramsey and Travers were studying liquefied air. They suspected that a hidden element must be present in addition to the argon they created in the process. When they ran the unknown element through a spectrometer, it was shown to indeed be krypton. Today, krypton is estracted from the Earth's atmosphere, although it makes up only 0.0001% of our air.\n\nKrypton is an inert gas, so it does not react with anything, but suprisingly, the only element it reacts with is fluorine. Because krypton is very expensive to obtain, its practical applications are limited. Krypton is used as a filling gas for energy-saving fluorescent lights and in some flash lamps for high-speed photography. Krypton gas combines with other gases to make luminous signs that glow a greenish-yellow light. Radioactive krypton isotopes were used in Soviet nuclear production during the cold war. These isotopes were byproducts of nuclear reactors, meaning that the Russian share was found by subtracting the amount from American reactors from the total in the air.\n\nDid you know that from 1960 to 1983 the isotope krypton-86 was used to define a standard measure of length? Roughly 1.65 million wavelengths of a line in the atomic spectrum of this isotope is what one meter was defined as.";
            SetAllText();
        }

        else if (elementSlider.value == 37)
        {
            atomicName = "Rubidium";
            atomicSymbol = "Rb";
            atomicMass = 85.4678;
            atomicMelt = 312.46;
            atomicBoil = 961;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 5;
            atomicGroup = 1;
            atomicDiscoverer = "Gustav Kirchhoff and Robert Bunsen";
            atomicYear = 1861;
            atomicIon = 4.177;
            atomicDensity = 1.53;
            atomicIsotopes = 1;
            atomicInfo = "Rubidium, whose name comes from rubidus, Latin for \"deepest red,\" was first discovered when samples of the mineral lepidolite (KLi2Al(Al, Si)3O10(F, OH)2) were analyzed with a spectroscope. The samples showed deep red spectral lines that were never seen by scientists before, indicating that there was an unknown element in the lepidolite. The rubidium was eventually isolated from the mineral. Today, rubinium is obtainable as a byproduct of refining lithium.\n\nRubidium is used in vacuum tubes as a getter, a material that combines with and removes trace gases that are unwanted in vacuum tubes. It is also used in manufacturing photocells and special tyes of glasses. It may be used as a propellant in ion engines in spacecraft because it is easily ionized. Since rubidium is slightly radioactive, it is used to locate brain tumors because it collects in the tumors but not in ordinary tissue. As more of rubidium's properties become known to scientists, its usefulness will increase greatly.\n\nDespite rubidium forming several compounds with other elements, none of these compounds are commercially useful. Some compounds containing rubidium include rubidium chloride (RbCl), rubidium monoxide (Rb2O) and rubidium copper sulfate (Rb2SO4 * CuSO4 * 6H2O). There is also rubidium silver iodide (RbAg4I5), which may be useful in thin film batteries because of its interesting electrical characteristics.\n\nAlthough rubidium is slightly radioactive, as stated earlier, it is typically non-toxic, but it has no known biological roles. However, it is chemically similar to potassium, so we absorb some rubidium from our food, and the average human stores about half a gram of it.";
            SetAllText();
        }

        else if (elementSlider.value == 38)
        {
            atomicName = "Strontium";
            atomicSymbol = "Sr";
            atomicMass = 87.62;
            atomicMelt = 1050;
            atomicBoil = 1655;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 5;
            atomicGroup = 2;
            atomicDiscoverer = "Adair Crawford";
            atomicYear = 1790;
            atomicIon = 5.695;
            atomicDensity = 2.64;
            atomicIsotopes = 4;
            atomicInfo = "Strontium, named after the town of Strontian, in Scotland, was first obtained in 1808 by Sir Humphry Davy by elecrolyzing a mixture of strontium chloride (SrCl2) and mercuric oxide (HgO). Today, strontium is obtained from celestite (SrSO4) and strontanite (SrCO3), the two most common ores containing strontium, by treating them with hydrochloric acid, forming strontium chloride. The sttontium chloride is then melted and electrolyzed to form strontium and chlorine gas.\n\nMost of the strontium produced today is used in producing color television picture tubes, refining zinc and, when combined with iron, making magnets. Two strontium compounds, strontium carbonate (SrCO3) and strontium nitrate (Sr(NO3)2), burn with a bright red flame and are therefore used in fireworks and signal flares. Strontium carbonate is also used in certain kinds of glass and is the base material for many other strontium compounds.\n\nStrontium-90, a radioactive isotope of strontium, is a common product of nuclear explosions. Its half life is roughly 28.8 years and decays into yttrium-90 via beta-minus decay. Strontium-90 is very dangerous due to its long half-life and its strong radioactivity. It accumulates in the skeletal system when it is taken in by humans, especially young children. Strontium-90 affects the production of new blood cells, which can eventually lead to death.";
            SetAllText();
        }

        else if (elementSlider.value == 39)
        {
            atomicName = "Yttrium";
            atomicSymbol = "Y";
            atomicMass = 88.9058;
            atomicMelt = 1795;
            atomicBoil = 3618;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 3;
            atomicDiscoverer = "Johan Gadolin";
            atomicYear = 1794;
            atomicIon = 6.217;
            atomicDensity = 4.47;
            atomicIsotopes = 1;
            atomicInfo = "Yttrium is named after the village of Ytterby, Sweden, where the element was first discovered in the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10). Today's methods of obtaining yttrium involves an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that has many rare earth elements.\n\nMetallic yttrium is not very widely used, but several of its compounds are. For instance, yttrium oxide (Y2O3) and yttrium orthovanadate (YVO4) are combined with europium to produce red phosphor that is used in televisions. Garnets made from ytrrium and iron (Y3Fe5O12) are used as microwave filters in microwave communications equipment, while garnets made from ytrrium and aluminum (Y3Al5O12) are used as simulated diamond in jewelry. Yttrium-90 is a radioactive isotope used to treat some cancers, such as liver cancer.\n\nYttrium has no known biological role, and its soluble salts are somewhat toxic.";
            SetAllText();
        }

        else if (elementSlider.value == 40)
        {
            atomicName = "Zirconium";
            atomicSymbol = "Zr";
            atomicMass = 91.224;
            atomicMelt = 2128;
            atomicBoil = 4682;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 4;
            atomicDiscoverer = "Martin Heinrich";
            atomicYear = 1789;
            atomicIon = 6.634;
            atomicDensity = 6.52;
            atomicIsotopes = 4;
            atomicInfo = "Zirconium, from the Persian word for gold-like, zargun, was first discovered when the composition of the mineral jargon (ZrSiO4) was analyzed. Obtaining pure zirconium is difficult because it is chemically similar to hafnium, which is always found mixed with deposits of zirconium, Today, zirconium is obtained from the minerals zircon (ZrSiO4) and baddeleyite (ZrO2) through a process known as the Kroll Process, named after William J. Kroll in Luxembourg.\n\nZirconium is a corrosion resistant metal that is used in many high performance pumps and valves, and because it is not a good absorber of neutrons, it is widely used in nuclear reactors. The zirconium must be nearly hafnium-free to be used in these reactors, however. Other uses for zirconium include being alloyed with steel to make some types of surgical equipment and as a getter for the removal of trace gases from vacuum tubes.\n\nAs a compound with oxygen to form zirconium dioxide (ZrO2), it is used to make crucibles and to line the walls of high temperature furnaces. As the compound zirconium carbonate (3ZrO2 * CO2 * H2O), it is used in lotions to treat poison ivy rashes.\n\nZirconium and many of its compounds have very low toxicity. Most of the zirconium that is absorbed into the body tends to pass through the gut, and it accumulates slightly more in the skeleton than in tissue.";
            SetAllText();
        }

        else if (elementSlider.value == 41)
        {
            atomicName = "Niobium";
            atomicSymbol = "Nb";
            atomicMass = 92.9064;
            atomicMelt = 2750;
            atomicBoil = 5017;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 5;
            atomicDiscoverer = "Charles Hatchett";
            atomicYear = 1801;
            atomicIon = 6.759;
            atomicDensity = 8.57;
            atomicIsotopes = 1;
            atomicInfo = "Niobium, named after the Greek mythological figure, Niobe, has a discovery story that is somewhat confusing. In 1734, samples of the mineral columbite ((Fe, Mn, Mg)(Nb, Ta)2O6) were sent to the British Museum in London, England. The columbite sat in the museum for years until it was analyzed. Upon analysis, there was an unknown element in the columbite, but it could not be isolated. The new element was known as columbium.\n\nIn 1809, English chemist and physicist William Hyde Wollaston compared the minerals columbite and tantalite ((Fe, Mn)(Ta, Nb)2O6) and declared that columbium was actually tantalum. This created confusion because tantalum and niobium are similar metals that are always found together and very difficult to isolate from their compounds.\n\nIn 1844, niobium was rediscovered when Heinrich Rose produced niobic acid and pelopic acid from samples of columbite and tantalite. Since these acids were very similar to each other, it would take until about 1866 when Swiss chemist Jean Charles Galissard de Marignac proved that the acids were produced from very different elements. Metallic niobium was finally isolated in 1864 by Swedish chemist Christian Wilhelm Blomstrand. Today, niobium is primarily obtained from the minerals columbite and pyrochlore ((Ca, Na)2Nb2O6(O, OH, F)).\n\nNiobium is used as an alloying agent and jewelry, but because of its superconductivity, it is made as an alloy with titanium to make superconductive magnets and wires. Niobium-tin and niobium-aluminum alloys are superconductive as well, so they are used in similar applications.";
            SetAllText();
        }

        else if (elementSlider.value == 42)
        {
            atomicName = "Molybdenum";
            atomicSymbol = "Mo";
            atomicMass = 95.95;
            atomicMelt = 2896;
            atomicBoil = 4912;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 6;
            atomicDiscoverer = "Peter Jacob Hjelm";
            atomicYear = 1781;
            atomicIon = 7.092;
            atomicDensity = 10.2;
            atomicIsotopes = 6;
            atomicInfo = "Molybdenum, whose name comes from molybdos, the Greek word for lead, was first discovered in the mineral molybdenite (MoS2) which had been confused as a lead compound. Most of today's molybdenum comes from molybdenite, wulfenite (PbMoO4) and powellite (CaMoO4). These minerals usually occur with tin and tungsten ores. Molybdenum is also obtained as a byproduct of mining and tungsten and copper processing.\n\nMolybdenum's high melting point makes it useful for electrodes of electrically heated glass furnaces. Some electrical filaments are also made of molybdenum. Molybdenum is primarily used as an alloying agent in steel, where it is added in concentrations between 0.25% and 8% to give it the ability to withstand pressures up to 300,000 pounds per square inch.\n\nMolybdenum disulfide (MoS2), a compound of molybdenum, is used as a lubricant in high-temperature environments. Another compound called molybdenum trioxide (MoO3) is used to adhere enamels to metals. Other compounds containing molybdenum include molybdic acid (H2MoO4), molybdenum hexafluoride (MoF6) and molybdenum phosphide (MoP2).\n\nAlthough molybdenum is toxic in large quantities, small amounts of molybdenum are essential for most animals and plants.";
            SetAllText();
        }

        else if (elementSlider.value == 43)
        {
            atomicName = "Technetium";
            atomicSymbol = "Tc";
            atomicMass = -98;
            atomicMelt = 2430;
            atomicBoil = 4538;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 7;
            atomicDiscoverer = "Carlo Perrier and Emilio Segre";
            atomicYear = 1937;
            atomicIon = 7.28;
            atomicDensity = 11;
            atomicIsotopes = 0;
            atomicInfo = "Technetium, whose name comes from the Greek word for artificial, technetos, was the first element to be artificially produced. It was done so in a device called a cyclotron, where molybdenum atoms were bombarded with deutrons to form this element, whereas today, technetium is created by bombarding molybdenum-98 atoms with neutrons. Molybdenum-98 decays into technetium-99 through beta-minus decay. While technetium has never been found on earth, there are spectral lines that have been seen in S-, M- and N-type stars.\n\nTechnetium-98 is the most stable isotope of technetium and has a half-life of around 4.2 million years. Once that time comes, it decays into ruthenium-98 through beta-minus decay. Small amounts of technetium make excellent corrosion inhibitors for steel, but this use for technetium is limited due to to its radioactivity, and because it is radioactive, technetium will likely never have any biological roles.\n\n(Note: A minus sign before the atomic mass of certain radioactive elements indicates the most stable isotope of these elements.)";
            SetAllText();
        }

        else if (elementSlider.value == 44)
        {
            atomicName = "Ruthenium";
            atomicSymbol = "Ru";
            atomicMass = 101.07;
            atomicMelt = 2607;
            atomicBoil = 4423;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 8;
            atomicDiscoverer = "Karl Karlovich Klaus";
            atomicYear = 1844;
            atomicIon = 7.361;
            atomicDensity = 12.1;
            atomicIsotopes = 7;
            atomicInfo = "Ruthenium, whose name is from the Latin word for the country of Russia, Ruthenia, was first discovered while a sample of platinum ore obtained from the Ural mountains was being analyzed. Ruthenium tends to occur along with platinum deposits and is primarily obtained today as a byproduct of mining and refining platinum and nickel.\n\nRuthenium's primary use is as an alloy agent. Adding 0.1% ruthenium to titanium makes it approximately 100 times more corrosion resistant. It is also added to platinum and palladium to strengthen them. Ruthenium-platinum and ruthenium-palladium alloys are used sometimes as jewelry and other times as electrical contacts that resist water.\n\nSome ruthenium compounds, such as ruthenium oxide (RuO4), are highly toxic and should be treated as carcinogenic.";
            SetAllText();
        }

        else if (elementSlider.value == 45)
        {
            atomicName = "Rhodium";
            atomicSymbol = "Rh";
            atomicMass = 102.9055;
            atomicMelt = 2237;
            atomicBoil = 3968;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 9;
            atomicDiscoverer = "William Hyde Wollaston";
            atomicYear = 1803;
            atomicIon = 7.459;
            atomicDensity = 12.4;
            atomicIsotopes = 1;
            atomicInfo = "Rhodium, from the Greek word for rose, rhodon, was obtained from a sample of platinum ore from South America. After the platinum and palladium were extracted from the ore, all that was left was a dark red powder. The powder was treated with hydrogen gas to remove the rhodium from the rest of the powder. Today, rhodium is obtained as a byproduct of mining nickel in the Sudbury region of Ontario, Canada.\n\nRhodium is used for making electrical contacts, jewelry and catalytic converters. The most frequesnt use of rhodium, however, is as an alloying agent with platinum and palladium. These alloys are used to make electrodes for spark plugs in aircraft and laboratory crucibles.\n\nRhodium has no known roles in biology and is suspected to be a carcinogen. It is the rarest of all non-radioactive metals.";
            SetAllText();
        }

        else if (elementSlider.value == 46)
        {
            atomicName = "Palladium";
            atomicSymbol = "Pd";
            atomicMass = 106.42;
            atomicMelt = 1828;
            atomicBoil = 3236;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 10;
            atomicDiscoverer = "William Hyde Wollaston";
            atomicYear = 1803;
            atomicIon = 833.7;
            atomicDensity = 12;
            atomicIsotopes = 6;
            atomicInfo = "Palladium, named after the asteroid Pallas and the Greek goddess of wisdom, was discovered while samples of platinum ore from South America were analyzed. Palladium is obtained today as a byproduct of mining and refining platinum, nickel, silver, copper and gold.\n\nPalladium is used to make springs for watches, surgical instruments, electrical contacts and dental fillings and crowns. When finely divided, palladium is a catalyst for the hydrogenation and dehydrogenation processes because at room temperature, palladium can absorb up to 900 times its own volume of hydrogen, making it easy to use in these processes. Palladium is also used to make jewelry and, as an alloy with gold, forms a material called white gold. Palladium dichloride (PdCl2), a palladium compound, can absorb large amounts of carbon monoxide (CO) gas and is therefore used in carbon monoxide detectors.\n\nPalladium does not have any biological roles in nature. It has low toxicity, but can cause skin, eye, or respiratory tract irritation on contact.";
            SetAllText();
        }

        else if (elementSlider.value == 47)
        {
            atomicName = "Silver";
            atomicSymbol = "Ag";
            atomicMass = 107.8682;
            atomicMelt = 1234.93;
            atomicBoil = 2435;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 11;
            atomicDiscoverer = "N/A";
            atomicYear = -3000;
            atomicIon = 7.576;
            atomicDensity = 10.501;
            atomicIsotopes = 2;
            atomicInfo = "Silver gets its name from the Anglo-Saxon word seolfor, but its chemical symbol is from the Latin word for silver, argentum.\n\nSilver is thought to be used by people for at least 5,000 years. Silver is obtained from ores such as argentite (Ag2S) and horn silver (AgCl), and also from deposits of ores with lead, gold or copper.\n\nSilver and many of its compounds have many uses. In its pure form, silver is the best conductor of heat and electricity of all known metals, so it is sometimes used to make electrical contacts and printed circuit boards. Silver is also the best known reflector of light, so it is commonly used in silver mirrors, but its reflectivity is a bit limited due to the protective coating it is given to keep it from tarnishing. Silver was once used to make coins, but other metals are now used in its place. Silver nitrate (AgNO3) is sensitive to light and is therefore used to make photographic films and papers, while silver iodide (AgI) is used for seeding clouds to produce rain.\n\nSilver does not have any known biological roles, but it does have antibacterial properties that can effectively kill lower organisms.";
            SetAllText();
        }

        else if (elementSlider.value == 48)
        {
            atomicName = "Cadmium";
            atomicSymbol = "Cd";
            atomicMass = 112.414;
            atomicMelt = 594.22;
            atomicBoil = 1040;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 12;
            atomicDiscoverer = "Friedrich Stromeyer";
            atomicYear = 1817;
            atomicIon = 8.994;
            atomicDensity = 8.69;
            atomicIsotopes = 3;
            atomicInfo = "Cadmium, whose name comes from the Latin word cadmia and the Greek word kadmeia, both of which are names for calamine (ZnCO3), was first discovered when samples of calamine were studied. When they were heated, some of the samples changed color while others did not. When the samples that changed color were further examined, it turned out that the color change was the work of an unknown element. There is only one mineral that contains signficant amounts of cadmium, greenockite (CdS), but it is not common enough to mine profitably. However, cadmium is also found in zinc ores and is found as a byproduct of mining and refining the ores.\n\nThere are limited used for cadmium because it is a poisonous metal, but like zinc, it is electroplated to other materials to protect them from corrosion, and because it absorbs neutrons so easily, it is used to make control rods for nuclear reactors. It is also used in rechargeable nickel-cadmium batteries. Cadmium alloys with silver to form solder, a metal with a low melting point used for joining electrical components, pipes and other metallic items, but it must be handled with care to prevent cadmium poisoning. Cadmium alloys with other metals to make fatigue-resistant, low-friction bearings.\n\nCadmium compounds with sulfur, hudrogen and oxygen to form hydrated cadmium sulfate, which is used in a device called a Weston cell, a battery that produces a precise voltage for calibrating medical and laboratory equipment. Cadmium sulfide, another cadmium compound, is udes sometimes as a yellow pigment for paints and dyes. Other cadmium compounds are used for phosphors in black and white television sets and in blue and green phosphors in color television sets.";
            SetAllText();
        }

        else if (elementSlider.value == 49)
        {
            atomicName = "Indium";
            atomicSymbol = "In";
            atomicMass = 114.818;
            atomicMelt = 429.75;
            atomicBoil = 2345;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 13;
            atomicDiscoverer = "Ferdinand Reich and Hieronymous Richter";
            atomicYear = 1863;
            atomicIon = 5.786;
            atomicDensity = 7.31;
            atomicIsotopes = 1;
            atomicInfo = "Indium, named after the bright indigo line in its spectrum, was discovered when the element thallium was being searched in samples of zinc ores. An indigo line in the sample's spectrum revealed that there was an unknown element in the ore. That unknown element came to be known as indium later on. Indium is about as abundant as silver, but it is easier to abtain since it occurs with more elements than silver does.\n\nOne use of indium is for coating the bearings of high speed motors because it allows for the even distribution of lubricating oil. Another use for indium is for doping germanium to make transistors. Indium is also used to make mirrors similar to silver mirrors but do not tarnish as quickly. It forms an alloy with gallium that melts into a liquid at room temperature.\n\nIndium has no known biological roles, but it is toxic if more than a few milligrams are consumed at any one time. It can affect the development of an embryo or fetus if consumed in higher amounts.";
            SetAllText();
        }

        else if (elementSlider.value == 50)
        {
            atomicName = "Tin";
            atomicSymbol = "Sn";
            atomicMass = 118.71;
            atomicMelt = 505.08;
            atomicBoil = 2875;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 5;
            atomicGroup = 14;
            atomicDiscoverer = "N/A";
            atomicYear = -2100;
            atomicIon = 7.344;
            atomicDensity = 7.287;
            atomicIsotopes = 8;
            atomicInfo = "Tin gets its name from the Anglo-Saxon word tin, but gets its chemical symbol from the Latin word for tin, stannum.\n\nAccording to archaeological evidence, people have used tin for nearly 5500 years. Tin is extracted from the mineral cassiterite (SnO2) by heating it in a furnace with carbon. Tin makes up only around 0.001% of the Earth's crust and is mostly mined in Malaysia.\n\nTin's resistance to corrosion makes it useful as a protective coating for other metals. Perhaps the most familiar use of tin is in cans, where it is applied to the inside and outside layers of the can to prevent it from rusting. Tin is also used to produce window glass in the Pilkington process, named after the British glass manufacturer Pilkington. In the Pilkington process, molten glass is poured onto a pool of molten tin. The glass floats on the surface of the tin and cools, forming solid, flat glass. Most window glass produced today is made that way. Finally, tin alloys with copper to make bronze, with lead to make pewter and solder and with niobium to make superconductive wire. Other tin alloys include fusible metal, bell metal and Babbitt metal, named after Isaac Babbit.\n\nAlthough tin has no known biological role in humans, but it may be essential to some species. While tin is generally non-toxic, certain organo-tin compounds must be handled with care, as they are poisonous.";
            SetAllText();
        }

        else if (elementSlider.value == 51)
        {
            atomicName = "Antimony";
            atomicSymbol = "Sb";
            atomicMass = 121.76;
            atomicMelt = 903.78;
            atomicBoil = 1860;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 5;
            atomicGroup = 15;
            atomicDiscoverer = "N/A";
            atomicYear = -1600;
            atomicIon = 8.64;
            atomicDensity = 6.685;
            atomicIsotopes = 2;
            atomicInfo = "Antimony's name comes from the Greek words anti and monos, meaning \"not alone\" when put together, but antimony's chemical symbol comes from its historic name, stibium.\n\nAntimony is an element that has been known since ancient times. It is sometimes found free in nature, but it is usually obtained from the ores stibnite (Sb2S3) and valentinite (Sb2O3). Antimony makes up only about 0.00002% of the Earth's crust.\n\nAntimony has its uses since it became known to humanity in ancient times. So long ago was antimony useful, in fact, that the ancient Egyptians used antimony in the form of stibnite for black eye make-up. Today, pure antimony is used to produce certain types of semiconductor devices, such as diodes and infrared detectors. Antimony is alloyed with other elements to produce things such as batteries, low friction metals, type metal and cable sheathing. Antimony compounds with other elements to make flame-proofing materials, paints, ceramic enamels, glass and pottery.\n\nAntimony and several of its compounds are toxic, so they do not have any known biological roles.";
            SetAllText();
        }

        else if (elementSlider.value == 52)
        {
            atomicName = "Tellurium";
            atomicSymbol = "Te";
            atomicMass = 127.60;
            atomicMelt = 722.66;
            atomicBoil = 1261;
            atomicPhase = "Solid";
            atomicClass = "Metalloid";
            atomicPeriod = 5;
            atomicGroup = 16;
            atomicDiscoverer = "Franz-Joseph Muller von Reichenstein";
            atomicYear = 1783;
            atomicIon = 9.01;
            atomicDensity = 6.232;
            atomicIsotopes = 5;
            atomicInfo = "Tellurium, whose name comes from the Latin word for Earth, tellus, was first discovered in aurum album, a gold ore, where it was originally thought to be antimony. Tellurium is found free in nature, but is most often found in the ores sylvanite (AgAuTe4), calaverite (AuTe2) and krennerite (AuTe2). Most tellurium produced today comes as a byproduct of mining and refining copper.\n\nTellurium is often doped with copper, tin, gold, or silver in semiconductor applications. Tellurium is also used to color glass and ceramics, is a primary ingredient in blasting caps and in rewritable CDs and DVDs. Tellurium is also used in alloys with copper and stainless steel to improve their machinability. When tellurium is added to lead, it makes the lead more resistant to acids and improves its hardness.\n\nTellurium has no known biological role because it is very toxic and can disturb the development of an embryo or fetus if consumed in certain amounts.";
            SetAllText();
        }

        else if (elementSlider.value == 53)
        {
            atomicName = "Iodine";
            atomicSymbol = "I";
            atomicMass = 126.9045;
            atomicMelt = 386.85;
            atomicBoil = 457.55;
            atomicPhase = "Solid";
            atomicClass = "Halogen";
            atomicPeriod = 5;
            atomicGroup = 17;
            atomicDiscoverer = "Bernard Courtois";
            atomicYear = 1811;
            atomicIon = 10.451;
            atomicDensity = 4.93;
            atomicIsotopes = 1;
            atomicInfo = "Iodine, from the Greek word for violet, iodes, was first discovered when sodium and potassium compounds were extracted from seaweed ash. Once the compounds were removed, the ash was further processed by pouring some sulfuric acid (H2SO4) onto it. However, too much acid was poured onto it by accident and a violet colored cloud erupted from the mass. The cloud scattered across the room and condensed on metal objects nearby. Solid iodine was created from this condensation. Today, iodine is mainly obtained from deposits of the minerals sodium iodate (NaIO3) and sodium periodate (NaIO4) in Chile and Bolivia.\n\nIodine is used as a test for starch and turns a deep blue on contact with the starch. Potassium iodide (KI) is used to make photographic film and is also used in conjunction with alcohol as an antiseptic for external wounds. Iodine-131, a radioactive iodine isotope, is used to treat some diseases of the thyroid gland.\n\nTrace amounts of iodine are part of thyroxin, a horomone produced by the thyroid gland that controls the body's physical and mental development rate. A shortage of iodine in the body can cause the thyroid gland to swell, so iodine is added to salt to form iodized salt to prevent this. However, pure iodine should be handled with care, as it can burn skin on contact and damage mucous membranes if ingested.";
            SetAllText();
        }

        else if (elementSlider.value == 54)
        {
            atomicName = "Xenon";
            atomicSymbol = "Xe";
            atomicMass = 131.293;
            atomicMelt = 161.36;
            atomicBoil = 165.03;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 5;
            atomicGroup = 18;
            atomicDiscoverer = "Sir William Ramsey and Morris M. Travers";
            atomicYear = 1898;
            atomicIon = 12.13;
            atomicDensity = 0.0059;
            atomicIsotopes = 6;
            atomicInfo = "Xenon, from the Greek word for stranger, xenon, was discovered shortly after the discoveries of krypton and neon, and its method of discovery was the same as those two elements: through liquefied air. About 0.0000087% of Earth's atmosphere is xenon.\n\nXenon is used in strobe lights very often because it produces a brilliant white light when it is excited with electricity. Light emitted from xenon lamps is also used to kill bacteria and to power ruby lasers. Because of its heavy weight, xenon ions were once used to fuel an experimental ion engine aboard Deep Space 1.\n\nXenon was initially thought to be completely inert, but it turns out that xenon forms compounds with fluorine, oxygen and platinum to form XePtF6, XeF2, XeF4, XeF6 and XeO4.";
            SetAllText();
        }

        else if (elementSlider.value == 55)
        {
            atomicName = "Cesium";
            atomicSymbol = "Cs";
            atomicMass = 132.9055;
            atomicMelt = 301.59;
            atomicBoil = 944;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 6;
            atomicGroup = 1;
            atomicDiscoverer = "Gustav Kirchhoff and Robert Bunsen";
            atomicYear = 1860;
            atomicIon = 3.894;
            atomicDensity = 1.93;
            atomicIsotopes = 1;
            atomicInfo = "Cesium, from the Latin word for sky blue, caesius, was discovered when Durkheim mineral water was analyzed and it was seen that the water had a blue spectrum. Today, cesium is primarily obtained from the mineral pollucite (CsAlSi2O6), but obtaining this element is hard because cesium ores are frequently contaminated with rubidium, which is similar to cesium. Cesium and rubidium ores must be heated with sodium metal to 650C to form an alloy that can then be separated through fractional distillation.\n\nCesium's uses are somewhat limited due to it having the second lowest melting point out of all the elements. However, it is used with oxygen as a getter to remove trace gases from vacuum tubes, and it is also used in atomic clocks, in photoelectric cells and as a catalyst for hydrogenating certain organic compounds. Because cesium is easily ionized and has a high mass, it could also one day be used as a propellant in ion engines in spacecraft.\n\nBeing an alkali metal, cesium reacts violently with water, forming cesium hydroxide (CsOH). Cesium hydroxide is the strongest known base and will not be held well with glass. However, cesium chloride (CsCl) and cesium nitrate (CsNO3) are cesium's most common compounds and are primarily used in producing other chemicals.\n\nCesium does not have any known roles in biology. Many of its compounds are low hazard, but contact with certain radioactive isotopes can lead to nausea, vomiting and some bleeding. How serious the side effects are depends on how resistant the person is to radiation poisoning and how long the person is exposed.";
            SetAllText();
        }

        else if (elementSlider.value == 56)
        {
            atomicName = "Barium";
            atomicSymbol = "Ba";
            atomicMass = 137.327;
            atomicMelt = 1000;
            atomicBoil = 2170;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 6;
            atomicGroup = 2;
            atomicDiscoverer = "Sir Humphry Davy";
            atomicYear = 1808;
            atomicIon = 5.212;
            atomicDensity = 3.62;
            atomicIsotopes = 6;
            atomicInfo = "Barium, from the Greek word for heavy, barys, is never found free in nature because it reacts with oxygen in the air to form barium oxide (BaO) and with water to form barium hydroxide (Ba(OH)2) and hydrogen gas. It was first obtained through the electrolysis of molten barya (BaO), whereas today, it is commonly found in the minerals barite (BaSO4) and witherite (BaCO3) and is primarily produced through the electrolysis of barium chloride (BaCl2).\n\nBarium is used as a getter to remove trace gases from vacuum tubes. It compounds with oxygen and sulfur to form barium sulfate (BaSO4), which is used as a filler for rubber, plastics and resins. Stones that are made from impure barium sulfate glow in light and will flow in the dark for up to six years if intensely heated while charcoal is present. Known as Bologna stones, which were first discovered in the 1500s in Bologna, Italy, were thought to posess magical properties by alchemists. While all barium compounds are poisonous, barium sulfate can safely be ingested because it does not dissolve in water. It is even used to produce X-ray images of the intestinal tract because it is an excellent absorber of X-rays.\n\nBarium does not have any biological roles, although traces of barium sulfate have been found in one type of algae.";
            SetAllText();
        }

        else if (elementSlider.value == 57)
        {
            atomicName = "Lanthanum";
            atomicSymbol = "La";
            atomicMass = 138.9055;
            atomicMelt = 1191;
            atomicBoil = 3737;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Carl Gustav Mosander";
            atomicYear = 1839;
            atomicIon = 5.577;
            atomicDensity = 6.15;
            atomicIsotopes = 1;
            atomicInfo = "Lanthanum, whose name comes from the Greek word lanthaneia, meaning \"to lie hidden,\" was discovered when a new substance called lanthana (La2O3) was found within a sample of cerium nitrate (Ce(NO3)3) when it was treated with a dilute solution of nitric acid (HNO3). Today, lanthanum is primarily obtained through an ion exchange process from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that contains up to 25% lanthanum.\n\nLanthanum is a rare earth element than is used to make carbon arc lights that are used in the motion picture industry for studio and projector lights. Lanthanum is also a part of Misch metal, a material used for making lighter flints. Another material, called lanthana (La2O3) is used for making glass used in camera lens and in other special glasses. The ion La3+ is used to biologically trace Ca2+, and radioactive lanthanum has been tested for its use in treating many types of cancer.\n\nLanthanum does not have any known biological roles. Both the element and several of its compounds are somewhat toxic.";
            SetAllText();
        }

        else if (elementSlider.value == 58)
        {
            atomicName = "Cerium";
            atomicSymbol = "Ce";
            atomicMass = 140.116;
            atomicMelt = 1071;
            atomicBoil = 3697;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Jons Jacob Berzelius and Wilhelm Hisinger";
            atomicYear = 1803;
            atomicIon = 5.539;
            atomicDensity = 6.77;
            atomicIsotopes = 1;
            atomicInfo = "Cerium, named after the asteroid Ceres and the Roman god of agriculture, is the most abundant of the rare earth elements and makes up about 0.0046% of the Earth's crust. Like lanthanum, it is also obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n\nPure cerium is dangerous to handle because it will ignite if it is scratched with a sharp object, but it is much safer when it is combined with other materials. Cerium, like lanthanum, is also used for making carbon arc lights for studio lighting and projection in the motion picture industry and in lighter flints for igniting flames. Cerium is also a catalyst to refine petroleum and as an alloying agent for special metals. Cerium oxide (Ce2O3 and CeO2) is a component of the walls of self-cleaning ovens and incandescent lantern mantles. Cerium oxide is also used to polish glass surfaces. Ceric sulfate (Ce(So4)2) is used in certain chemical analysis processes. Other cerium compounds are used to make some types of glass and to remove color from glass.\n\nCerium does not have any known biological roles in nature, but there are some cerium salts that stimulate metabolism in some organisms.";
            SetAllText();
        }

        else if (elementSlider.value == 59)
        {
            atomicName = "Praseodymium";
            atomicSymbol = "Pr";
            atomicMass = 140.9077;
            atomicMelt = 1204;
            atomicBoil = 3793;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Carl Auer von Welsbach";
            atomicYear = 1885;
            atomicIon = 5.464;
            atomicDensity = 6.77;
            atomicIsotopes = 1;
            atomicInfo = "Praseodymium, from the Greek words prasios and didymos, which mean \"green twin\" together, was separated from a material known as didymium, where they were both first discovered from. It is now obtained through monazite sand ((Ce, La, Th, Nd, Y)PO4), as is the case with lanthanum and cerium.\n\nPraseodymium's primary use is as an alloy with magnesium to create high-strength metals used in aircraft engines. Praseodymium also makes up about 5% of Misch metal, a metal used for making flints for lighters. Praseodymium, like lanthanum and cerium, is also used in lighting for the motion picture industry. Finally, praseodymium is a component of didymium glass, which is used to make certain types of welder's glass and blower's glass.\n\nPraseodymium has low toxicity, but it has no known biological roles.";
            SetAllText();
        }

        else if (elementSlider.value == 60)
        {
            atomicName = "Neodymium";
            atomicSymbol = "Nd";
            atomicMass = 144.242;
            atomicMelt = 1294;
            atomicBoil = 3347;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Carl Auer von Welsbach";
            atomicYear = 1885;
            atomicIon = 5.525;
            atomicDensity = 7.01;
            atomicIsotopes = 5;
            atomicInfo = "Neodymium, from the Greek words neos didymos, which come together to form \"new twin,\" was separated, along with praseodymium, from the material didymium, where they were first discovered. Today, it is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n\nLike lanthanum, cerium and praseodymium, neodymium is also used for making flints for lighters, but unlike these elements, neodymium is used in some glasses to calibrate spectrometers and in other glasses to make artificial rubies for lasers. Some neodymium salts are used for coloring enamels and glazes.\n\nNeodymium has no biological roles in nature and it can irritate the eyes on contact.";
            SetAllText();
        }

        else if (elementSlider.value == 61)
        {
            atomicName = "Promethium";
            atomicSymbol = "Pm";
            atomicMass = -145;
            atomicMelt = 1315;
            atomicBoil = 3273;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Jacob Marinsky, Lawrence Glendenin and Charles Coryell";
            atomicYear = 1945;
            atomicIon = 5.55;
            atomicDensity = 7.26;
            atomicIsotopes = 0;
            atomicInfo = "Promethium, named after the Greek mythological figure Prometheus, was first discovered during World War II when the byproducts of uranium fission were analyzed after being produced in a nuclear reactor located at Clinton Laboratories (now Oak Ridge National Laboratory) in Oak Ridge, Tennessee. Promethium is still collected today as fission byproducts, but it can also be produced by bombarding neodymium-146 with neutrons. When neodymium-146 captures a neutron, it becomes neodymium-147, which has a half-life of 11 days and decays through beta-minus decay in to promethium-147. Promethium, despite being classified as a rare earth element, does not occur naturally, although it has been detected once in the spectrum of a star in the Andromeda constellation.\n\nTheoretically, promethium could be used to make a nuclear-powered battery that would use the beta particles emitted by the decay of promethium to make a phosphor give off light. The light would then be converted into electricity by a device similar to a solar cell. The expected lifespan of a bettery like this would last approximately 5 years. Promethium could also be used as a portable source of X-rays, in radioisotope thermoelectric generators for providing electricity for space probes and satellites, as a source for radioactivity for gauges that measure thickness and to make lasers that can be used to communicate with submarines that are under the water.\n\nAs promethium does not occur in nature, it will likely never have any uses in biology, and because it is radioactive, it is harmful to living things.";
            SetAllText();
        }

        else if (elementSlider.value == 62)
        {
            atomicName = "Samarium";
            atomicSymbol = "Sm";
            atomicMass = 150.36;
            atomicMelt = 1347;
            atomicBoil = 2067;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Paul-Emile Lecoq de Boisbaudran";
            atomicYear = 1879;
            atomicIon = 5.644;
            atomicDensity = 7.52;
            atomicIsotopes = 5;
            atomicInfo = "Samarium is named for the mineral samarskite ((Y, Ce, U, Fe)3(Nb, Ta, Ti)5O16), from which it was first extracted, whereas today, it is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that may contain as much as 2.8% samarium.\n\nSamarium is yet another element used in carbon arc lights used in the motion picture industry for studio and projector lights and is yet another element that makes up Misch metal, a material used to make flint for lighters. Samarium compounds with cobalt (SmCo5) to form a powerful permanent magnet with the highest resistance to demagnetization of any known material. Samarium oxide (Sm2O3) is added to glass to absorb infrared radiation and acts as a catalyst for dehydrating and dehydrogenating ethanol (C2H6O).\n\nSamarium has no known biological roles, and it is toxic, but only in huge doses.";
            SetAllText();
        }

        else if (elementSlider.value == 63)
        {
            atomicName = "Europium";
            atomicSymbol = "Eu";
            atomicMass = 151.964;
            atomicMelt = 1095;
            atomicBoil = 1802;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Eugene-Anatole Demarcay";
            atomicYear = 1901;
            atomicIon = 5.67;
            atomicDensity = 5.24;
            atomicIsotopes = 1;
            atomicInfo = "Europium, named after the continent of Europe, was suspected to exist after samples of the recently discovered element samarium were processed. Today, europium is primarily obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material rich in rare earth elements.\n\nEuropium is the most reactive of the rare earth elements. There are no known commercial applications for Europium metal, although it has been used as a dope in some plastics to make lasers. It is also being studied for its use in nuclear reactors because it is a good absorber of neutrons. Europium oxide, a compound of europium, is widely used as a red phosphor in TV sets and as and activator for yttrium-based phosphors.\n\nEuropium has no known biological roles. It has low toxicity, although it has not been fully investigated yet.";
            SetAllText();
        }

        else if (elementSlider.value == 64)
        {
            atomicName = "Gadolinium";
            atomicSymbol = "Gd";
            atomicMass = 157.25;
            atomicMelt = 1586;
            atomicBoil = 3546;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Jean Charles Galissard de Marignac";
            atomicYear = 1880;
            atomicIon = 6.15;
            atomicDensity = 7.9;
            atomicIsotopes = 5;
            atomicInfo = "Gadolinium is named for the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10), which was named after Finnish chemist Johan Gadolin. Spectroscopic evidence for gadolinium was first observed in samples of the minerals didymia and gadolinite. Today, gadolinium is obtained from the minerals monazite ((Ce, La, Th, Nd, Y)PO4) and bastnasite ((Ce,La,Y)CO3F).\n\nSince gadolinium has the greatest ability of capturing thermal neutrons of all known elements, it is often used as rods for nuclear reactors, but they lose effectiveness very quickly because the two isotopes best suited for neutron capture, gadolinium-155 and gadolinium-157 are present in gadolinium in small amounts.\n\nWhen combined with yttrium, gadolinium forms garnets that are used in microwave technology. It alloys with iron, chromium and other metals to improve their resistances to hight temperatures and corrosion. Gadolinium compounds are also used for making phosphors for color TVs.\n\nGadolinium does not have any known roles in biology. Its toxicity is low, but like europium, it has not been fully investigated yet.";
            SetAllText();
        }

        else if (elementSlider.value == 65)
        {
            atomicName = "Terbium";
            atomicSymbol = "Tb";
            atomicMass = 158.9253;
            atomicMelt = 1629;
            atomicBoil = 3503;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Carl Gustav Mosander";
            atomicYear = 1843;
            atomicIon = 5.864;
            atomicDensity = 8.23;
            atomicIsotopes = 1;
            atomicInfo = "Terbium is named for the village of Ytterby, Sweden, where it was first discovered within the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10). The gadolinite was split into three materials that were named yttria, erbia and terbia. Two of the materials, terbia and erbia, would be named terbium and erbium, respectively. Today, terbium is found in the minerals xenotime (YPO4) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6), but most of it is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that typically contains as much as 0.03% terbium.\n\nOne use for terbium is as a dope for certain types of solid-state devices. Another use, along with zirconium dioxide (ZrO2), is as a crystal stabilizer in fuel cells that operate at very high temperatures. Terbium oxide (Tb2O3), a compound of terbium, can potentially be used to activate green phosphors in TV tubes. Sodium terbum borate, another compound of terbium, is used for making laser light.\n\nTerbium has no known roles in biology and is mildly toxic, though this hasn't been fully investigated yet.";
            SetAllText();
        }

        else if (elementSlider.value == 66)
        {
            atomicName = "Dysprosium";
            atomicSymbol = "Dy";
            atomicMass = 162.5;
            atomicMelt = 1685;
            atomicBoil = 2840;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Paul-Emile Lecoq de Boisbaudran";
            atomicYear = 1886;
            atomicIon = 5.939;
            atomicDensity = 8.55;
            atomicIsotopes = 7;
            atomicInfo = "Dysprosium, from the Greek word dysprositos, which means \"hard to get at,\" was first discovered as an impurity in erbia, the oxide of erbium. It was isolated in 1906 by French chemist Georges Urbain. Pure dysprosium was first produced in the 1950s through ion-exchange chromatograpgy, while today, it is extracted from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material containing lots of rare earth elements.\n\nDysprosium currently does not have any commercial applications, but because it easily absorbs neutrons and has a high melting point, dysprosium may be used as an alloy with steel for nuclear reactors in the future. When combined with vanadium and other rare earth elements, it is used as a laser material. Dysprosium oxide (Dy2O3), a compound of dysprosium, is used with nickel as an additive to a special cement used for cooling nuclear reactor rods. Other compounds of dysprosium include dysprosium fluoride (DyF3), dysprosium iodide (DyI3) and dysprosium sulfate (Dy2(SO4)3).\n\nDysprosium has no known roles in biology. Soluble dysprosium salts are mildly toxic by ingestion, while insoluble salts are non-toxic. Approximately 500 grams of toxic dysprosium salts are needed to put a normal person's life at risk.";
            SetAllText();
        }

        else if (elementSlider.value == 67)
        {
            atomicName = "Holmium";
            atomicSymbol = "Ho";
            atomicMass = 164.9303;
            atomicMelt = 1747;
            atomicBoil = 2973;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Per Teodor Cleve and Marc Delafontaine";
            atomicYear = 1878;
            atomicIon = 6.022;
            atomicDensity = 8.8;
            atomicIsotopes = 1;
            atomicInfo = "Holmium, from the Latin word for the city of Stockholm, Holmia, was first discovered when impurites were being searched in the oxides of rare earth elements. Two new materials were obtained from the oxides, one of which was brown and the other was green. The brown material was named holmia and the green one was named thulia. Holmia is the oxide of the element holmium and thulia is the oxide of the element thulium. Today, holmium is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that contains up to 0.05% holmium.\n\nHolmium has very few commercial applications, but it has unusual magnetic properties that may be useful in future applications. It forms many compounds with other elements, including holmium oxide (Ho2O3), holmium fluoride (HoF3) and holmium iodide (HoI3), none of which have any commercial applications either.\n\nHolmium has no known biology roles and is the least abundant element in the human body, but it poses no environmental threats to plants or animals.";
            SetAllText();
        }

        else if (elementSlider.value == 68)
        {
            atomicName = "Erbium";
            atomicSymbol = "Er";
            atomicMass = 167.259;
            atomicMelt = 1802;
            atomicBoil = 3141;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Carl Gustav Mosander";
            atomicYear = 1843;
            atomicIon = 6.108;
            atomicDensity = 9.07;
            atomicIsotopes = 6;
            atomicInfo = "Erbium, named after the village of Ytterby, Sweden, was first discovered in the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10). The gadolinite was split into three materials: yttria, erbia and terbia. Two of these materials, erbia and terbia, were confused with one another because of their similar properties. Later on, the two materials would have their names switched up so that erbia is now called terbia and terbia is now called erbia. Then, terbium would be discovered from terbia, and erbium would be discovered from erbia. Today, erbium is primarily obtained via an ion exchange process from the minerals xenotime (YPO4) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6).\n\nErbium forms an alloy with vanadium to make it softer and easier to shape. Erbium is added to fiber optic cables as a doping agent where it is used as a signal amplifier. It is also used for some applications in the nuclear power industry. Erbium oxide (Er2O3), a compound of erbium, has a pink color and is used to color dlass and glazes. Other compounds include erbium fluoride (ErF3), erbium chloride (ErCl3) and erbium iodide (ErI3).\n\nErbium has no known biological roles, and it is difficult to determine how much erbium is present in the human body. The levels are highest in the bones, but there are smaller, varying amounts present in the liver and kidneys.";
            SetAllText();
        }

        else if (elementSlider.value == 69)
        {
            atomicName = "Thulium";
            atomicSymbol = "Tm";
            atomicMass = 168.9342;
            atomicMelt = 1818;
            atomicBoil = 2223;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Per Teodor Cleve";
            atomicYear = 1879;
            atomicIon = 6.184;
            atomicDensity = 9.32;
            atomicIsotopes = 1;
            atomicInfo = "Thulium, from the earliest name for Scandinavia, Thule, was first discovered when impurites were being searched in the oxides of rare earth elements. Two new materials were obtained from the oxides, one of which was brown and the other was green. The brown material was named holmia and the green one was named thulia. Holmia is the oxide of the element holmium and thulia is the oxide of the element thulium. Thulium can be obtained today through an ion exchange process of monazite sand ((Ce, La, Th, Nd, Y)PO4), a material that contains 0.007% thulium at most.\n\nThulium is the least abundant of the naturally occurring rare earth elements, so it may be difficult to find. Thulium has no commercial applications, but one of its isotopes, thulium-169, can potentially be used as a radiation source for portable X-ray machines. Thulium compounds with other elements to form thulium oxide (Tm2O3), thulium fluoride (TmF3) and thulium iodide (TmI3), but none of these compounds are commercially useful.\n\nThulium does not have any roles in biology. Soluble thulium salts are toxic in large amounts.";
            SetAllText();
        }

        else if (elementSlider.value == 70)
        {
            atomicName = "Ytterbium";
            atomicSymbol = "Yb";
            atomicMass = 173.045;
            atomicMelt = 1092;
            atomicBoil = 1469;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Jean Charles Galissard de Marignac";
            atomicYear = 1878;
            atomicIon = 6.254;
            atomicDensity = 6.9;
            atomicIsotopes = 7;
            atomicInfo = "Ytterbium, named for the village of Ytterby, Sweden, was discovered when the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) was split into three materials: yttria, erbia and terbia. It was discovered that erbia had two components, one of which was named ytterbia while the other retained the name erbia.\n\nSome scientists believed that ytterbia was a compound of a new element that would be known as ytterbium, while others produced and experimented with ytterbium to try to determine some of its properties. Unfortunately, different scientists obtained different results from the same experiments.\n\nWhile these scientists believed that it was because their procedures or equipment were faulty, another scientist, Georges Urbain, believed that ytterbium was not a single element, but a mixture of two elements. In 1907, he was able to separate ytterbium into two new elements: neoytterbium (new ytterbium) and lutecium. The name neoytterbium was eventually changed back to ytterbium and lutecium's name was changed to lutetium. Today, ytterbium is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4) through an ion exchange process.\n\nYtterbium is alloyed with stainless steel to improve some of its mechanical properties and is used as an amplifier for fiber optic cable. An isotope of ytterbium has some potential to be used as a source of radiation for portable X-ray machines.\n\nAlthough ytterbium has no known biological roles, its salts have been noted to stimulate metabolism.";
            SetAllText();
        }

        else if (elementSlider.value == 71)
        {
            atomicName = "Lutetium";
            atomicSymbol = "Lu";
            atomicMass = 174.9668;
            atomicMelt = 1936;
            atomicBoil = 3675;
            atomicPhase = "Solid";
            atomicClass = "Lanthanoid";
            atomicPeriod = 6;
            atomicGroup = 0;
            atomicDiscoverer = "Georges Urbain";
            atomicYear = 1907;
            atomicIon = 5.426;
            atomicDensity = 9.84;
            atomicIsotopes = 1;
            atomicInfo = "Lutetium, from an ancient name for the city of Paris, Lutetia, was discovered when the mineral gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) was split into three materials: yttria, erbia and terbia. It was discovered that erbia had two components, one of which was named ytterbia while the other retained the name erbia.\n\nSome scientists believed that ytterbia was a compound of a new element that would be known as ytterbium, while others produced and experimented with ytterbium to try to determine some of its properties. Unfortunately, different scientists obtained different results from the same experiments.\n\nWhile these scientists believed that it was because their procedures or equipment were faulty, another scientist, Georges Urbain, believed that ytterbium was not a single element, but a mixture of two elements. In 1907, he was able to separate ytterbium into two new elements: neoytterbium (new ytterbium) and lutecium. Austrian chemist Carl Auer von Welsbach reached the same conclusions at about the same time. Welsbach chose the names albebaranium and cassiopium for the elements, but Urbain is credited with the discovery and won the right to rename them to ytterbium and lutetium. Today, lutetium is obtained from monazite sand ((Ce, La, Th, Nd, Y)PO4) through an iron exchange process.\n\nBecause lutetium is one of the most difficult elements to prepare, it has no large scale practical uses. However, some of its radioactive isotopes could be used as a catalyst for cracking petroleum products and in some hydrogenation and polymerization processes.\n\nLutetium does not have any biological roles and is mildly toxic by ingestion, but its soluble salts are safe to handle.";
            SetAllText();
        }

        else if (elementSlider.value == 72)
        {
            atomicName = "Hafnium";
            atomicSymbol = "Hf";
            atomicMass = 178.49;
            atomicMelt = 2506;
            atomicBoil = 4876;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 4;
            atomicDiscoverer = "George Charles de Hevesy and Dirk Coster";
            atomicYear = 1923;
            atomicIon = 6.825;
            atomicDensity = 13.3;
            atomicIsotopes = 5;
            atomicInfo = "Hafnium, from the Latin word for the city of Copenhagen, Hafnia, was discovered with a method called X-ray spectroscopy to study the arrangement of the outer electrons of atoms in zirconium ore. Hafnium is hard to extract from zirconium because the two elements' atoms are the same size.\n\nHafnium is a good absorber of neutrons, so it is used often in the control rods of nuclear reactors. It is also used in vacuum tubes as a getter to remove trace gases from the tubes. Hafnium is used as an alloying agent in iron, titanium, niobium and many other metals. Hafnium oxide (HfO2) has been used in microchips, while hafnium catalysts have been used in polymerisation reactions.\n\nHafnium has no known biological roles and generally has low toxicity, but no signs or symptoms of chronic exposure have been reported in humans.";
            SetAllText();
        }

        else if (elementSlider.value == 73)
        {
            atomicName = "Tantalum";
            atomicSymbol = "Ta";
            atomicMass = 180.9479;
            atomicMelt = 3290;
            atomicBoil = 5731;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 5;
            atomicDiscoverer = "Anders Gustav Ekeburg";
            atomicYear = 1802;
            atomicIon = 7.89;
            atomicDensity = 16.4;
            atomicIsotopes = 1;
            atomicInfo = "Tantalum, named for the Greek mythological figure Tantalus, was first believed to be identical to an allotrope of niobium until it was proven that tantalum and niobium were two seperate elements. The first time pure tantalum was produced was in 1907, but today, it comes from the minerals columbite ((Fe, Mn, Mg)(Nb, Ta)2O6), tantalite ((Fe, Mn)(Ta, Nb)2O6) and euxenite ((Y, Ca, Er, La, Ce, U, Th)(Nb, Ta, Ti)2O6).\n\nTantalum is a strong metal that is nearly immune to all chemical attacks at room temperature. It is drawn into fine wires used to evaporate metals and is frequently a substitute for platinum, a much more expensive metal. Tantalum is also used to make components for chemical plants, nuclear power plants, airplanes, missiles, surgical equipment, implants and artificial joints. Tantalum pentoxide (Ta2O5), a compound of tantalum, is dielectric and is used to make capacitors.\n\nTantalum has no known biological roles and should not be released into the environment without proper government permits. Runoffs of tantalum oxides should be isolated to prevent environmental pollution.";
            SetAllText();
        }

        else if (elementSlider.value == 74)
        {
            atomicName = "Tungsten";
            atomicSymbol = "W";
            atomicMass = 183.84;
            atomicMelt = 3695;
            atomicBoil = 5828;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 6;
            atomicDiscoverer = "Juan and Fausto Elhuyar";
            atomicYear = 1783;
            atomicIon = 7.98;
            atomicDensity = 19.3;
            atomicIsotopes = 2;
            atomicInfo = "Tungsten's name comes from the Swedish words tung and sten, which mean \"heavy stone\" when put together, while tungsten's chemical symbol comes from its earlier, Germanic name, Wolfram, which comes from the mineral wolframite ((Fe, Mn)WO4), in which it was first discovered. Today, tungsten also comes from scheelite (CaWO4), which is crushed, cleaned, and treated with alkalis to form tungsten trioxide (WO3), which is then treated with either carbon or hydrogen gas. This would form tungsten metal and either carbon dioxide (CO2) or water vapor (H2O) depending on which method of heating is used.\n\nPure tungsten is soft enough to be cut with a hacksaw and ductile enough to either be drawn into wire or extruded into various shapes, but if other materials get into the tungsten, it becomes very brittle and difficult to work with. Tungsten has the highest melting point of all metallic elements and is therefore used to make filaments for incandescent lightbulbs and TV tubes. Tungsten is also used to make metal to glass seals and as a target for X-ray production. It is also a part of electric furnaces as heating elements and for parts of spacecraft and missiles that must withstand high temperatures. Tungsten carbide (WC) is an extremely durable tungsten compound used in the tips of drill bits, high speed cutting tools, and mining machinery. Tungsten disulfide (WS2), another tungsten compound, is a dry lubricant that is useable in temperatures as high as 500C. Tungsten compounds with calcium and magnesium to have phosphorescent properties that are used in fluorescent light bulbs.\n\nIt's been a while since we have come across an element with a biological role, but here we are at tungsten being used in the enzymes of some types of bacteria to reduce carboxylic acids to aldehydes. Tungsten is actually the heaviest known metal to have a biological role.";
            SetAllText();
        }

        else if (elementSlider.value == 75)
        {
            atomicName = "Rhenium";
            atomicSymbol = "Re";
            atomicMass = 186.207;
            atomicMelt = 3459;
            atomicBoil = 5869;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 7;
            atomicDiscoverer = "Walter Noddack, Ida Tacke and Otto Berg";
            atomicYear = 1925;
            atomicIon = 7.88;
            atomicDensity = 20.8;
            atomicIsotopes = 1;
            atomicInfo = "Rhenium, from the Latin word for the Rhine River, Rhenus, was spectroscopically detected in platinum ores and in the minerals columbite ((Fe, Mn, Mg)(Nb, Ta)2O6), gadolinite ((Ce, La, Nd, Y)2FeBe2Si2O10) and molybdenite (MoS2), but it is only present in these minerals in very small amounts. Today, rhenium is obtained as a byproduct of refining molybdenum and copper.\n\nRhenium is often used in photographic flash lamps and for filaments in mass spectrographs and ion gauges, but its primary use is as an alloying agent in tungsten and molybdenum and as a catalyst for performing certain reactions to a type of hydrocarbon known as an olefin.\n\nRhenium has no known biological roles, and it may cause eye and skin irritation on contact, but not much else is known about its toxicity.";
            SetAllText();
        }

        else if (elementSlider.value == 76)
        {
            atomicName = "Osmium";
            atomicSymbol = "Os";
            atomicMass = 190.23;
            atomicMelt = 3306;
            atomicBoil = 5285;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 8;
            atomicDiscoverer = "Smithson Tennant";
            atomicYear = 1803;
            atomicIon = 8.7;
            atomicDensity = 22.57;
            atomicIsotopes = 5;
            atomicInfo = "Osmium, from the Greek word for a smell, osme, was discovered at the same time as iridium was. They were both identified after platinum ore was dissolved using aqua regia, which is a mixture of 25% nitric acid (HNO3) and 75% hydrochloric acid (HCl). Today, osmium is obtainable from the processing of platinum and nickel ores.\n\nMetallic oxygen is very difficult to make because it is hard and brittle. Powdered osmium is much easier to produce, but when it is exposed to the air, it emits osmium tetroxide (OsO4), which is very toxic and smells horrible. For these reasons, osmium is primarily used to make alloys with other elements, which are used in ballpoint pen tips, fountain pen tips, record player needles, electrical contacts and other applications where lots of friction is present.\n\nDue to how toxic its oxide is and how much potential harm it could do to living organisms, osmium has no biological roles.";
            SetAllText();
        }

        else if (elementSlider.value == 77)
        {
            atomicName = "Iridium";
            atomicSymbol = "Ir";
            atomicMass = 192.217;
            atomicMelt = 2719;
            atomicBoil = 4701;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 9;
            atomicDiscoverer = "Smithson Tennant";
            atomicYear = 1803;
            atomicIon = 9.1;
            atomicDensity = 22.42;
            atomicIsotopes = 2;
            atomicInfo = "Iridium, from the Latin word for rainbow, iris, was discovered at the same time as osmium was. They were both identified after platinum ore was dissolved using aqua regia, which is a mixture of 25% nitric acid (HNO3) and 75% hydrochloric acid (HCl). Today, iridium is obtained as a byproduct of mining and processing platinum and nickel.\n\nPure iridium is brittle and almost impossible to machine, but it is mainly used to harden platinum. Platinum-iridium alloys care used to make crucibles and other high temperature equipment. Iridium can also be alloyed with osmium to make fountain pen tips and compass bearings. Since iridium is the most resistant to corrosion of any known metal, the standard meter bat was created from an alloy of 90% platinum and 10% iridium. This bar would then be replaced in 1960 when the meter was redefined in terms of the orange-red spectral line of the isotope krypton-86.\n\nAt the end of the Cretaceous period, a thin layer of sediment containing iridium was put down after a large meteor struck Earth at that time. Dust from the impact spread around the globe and blocked the sun for many years, killing off many plant and animal species, among them the dinosaurs. Meteors and asteroids contain higher levels of iridium than the Earth's crust, so most of the iridium in the dust might have come from the meteor itself.\n\nIridium has no known biological roles, but it can irritate the eyes on contact.";
            SetAllText();
        }

        else if (elementSlider.value == 78)
        {
            atomicName = "Platinum";
            atomicSymbol = "Pt";
            atomicMass = 195.084;
            atomicMelt = 2041.55;
            atomicBoil = 4098;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 10;
            atomicDiscoverer = "Antonio de Ulloa";
            atomicYear = 1735;
            atomicIon = 9;
            atomicDensity = 21.46;
            atomicIsotopes = 5;
            atomicInfo = "Platinum, from the Spanish word for silver, platina, was used by the pre-Columbian Indians of South America. It was was not known to western scientists at the time, but it was first introduced to Europe in around 1750. Platinum occurs free in nature and is sometimes found in gold-bearing sand deposits, mostly in the Ural mountains, Columbia and the western United States.\n\nPlatinum is a soft, dense, ductile and corrosion resistant metal. Because it is so expensive, it is extensively used to make jewelry, but it is mainly used in catalytic converters for cars, trucks and buses, accounting for about 50% of its demand every year. Platinum is also used in the electronics industry to make computer hard disks and thermocouples. It can also make LCDs, turbine blades, pacemakers and dental fillings. Some platinum compounds are used in chemotherapy drugs to treat cancer.\n\nPlatinum has no known biological roles, but is non-toxic as a metal.";
            SetAllText();
        }

        else if (elementSlider.value == 79)
        {
            atomicName = "Gold";
            atomicSymbol = "Au";
            atomicMass = 196.9666;
            atomicMelt = 1337.33;
            atomicBoil = 3129;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 11;
            atomicDiscoverer = "N/A";
            atomicYear = -3000;
            atomicIon = 9.226;
            atomicDensity = 19.282;
            atomicIsotopes = 1;
            atomicInfo = "Gold's name comes from the Sanskrit word Jval and the Anglo-Saxon word gold, while gold's chemical symbol comes from the Latin word for gold, aurum.\n\nGold is a highly valued metal and has been known for at least 5500 years. Gold is found free in nature but mainly in conjunction with silver, quartz (SiO2), calcite (CaCO3), lead, tellurium, zinc or copper. It has been estimated that all gold that has currently been refined could be placed in a cube about 20 meters wide by 20 meters tall by 20 meters long.\n\nBecause gold is so valuable, it is widely used in jewelry along with silver, copper, platinum and palladium. These alloys are also used in decorative items, coins and dental fillings. The amount of gold in an alloy is measured with a unit called a karat. A karat is equal to one part gold to twenty-four parts alloy metals. For example, an 18 karat gold ring would contain 18 parts gold and 6 parts other metals.\n\nGold is a good conductor of electricity and heat and does not tarnish when it is exposed to the air, so it can be used to make electrical commectors and printed circuit boards. Gold is also a good reflector of infrared light, so it can be used to shield spacecraft and skyscrapers from the sun's heat, and gold-coated mirrors can be used to make telescopes that are sensitive to infrared light. One radioactive isotope of gold, called gold-198, is used for treating cancer, while a compound of gold, called gold sodium thiosulfate (AuNa3O6S4) is used as an arthritis treatment.\n\nGold has no known biological roles, but it is non-toxic.";
            SetAllText();
        }

        else if (elementSlider.value == 80)
        {
            atomicName = "Mercury";
            atomicSymbol = "Hg";
            atomicMass = 200.592;
            atomicMelt = 234.32;
            atomicBoil = 629.88;
            atomicPhase = "Liquid";
            atomicClass = "Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 12;
            atomicDiscoverer = "N/A";
            atomicYear = -1500;
            atomicIon = 10.438;
            atomicDensity = 13.5336;
            atomicIsotopes = 7;
            atomicInfo = "Mercury is named afer the planet Mercury in our solar system, but mercury gets its chemical symbol from the Greek word hydrargyrum, which means \"liquid silver.\"\n\nMercury was known by the Chinese and Hindus since ancient times and has been found in Egyptian tombs around 3,500 years ago. Mercury is not found free in nature and is usually obtained from the mineral cinnabar (HgS). Around half of the world's supply of mercury comes from Spain and Italy.\n\nMercury is used to make thermometers, barometers and other scientific instruments. Its conductivity to electricity is useful in position dependent switches and its vapors are used to make streetlights, fluorescent lamps and advertising signs. Mercury forms alloys with other metals such ad gold, silver, zinc and cadmium, but these alloys are known as amalgams. Amalgams are used to extract gold from ores, create dental fillings (with silver) and extend the life of dry cell batteries (with zinc and cadmium). Mercuric chloride (HgCl2), a compound of mercury, is a very poisonous salt that was used for disinfecting ounds, but another compound, mercurous chloride (Hg2Cl2), is used in some other processes for killing bacteria. Other mercury compounds include mercuric sulfide (HgS) and mercuric oxide (HgO), which are respectively used for making a red paint pigment called vermilion and for making mercury batteries.\n\nWhile mercury is present in all living things in some amounts and in every mouthful of food we eat, it is poisonous in high doses and can cause severe illness if too much accumulates in the body. One form of mercury, called methylmercury, is particularly dangerous and can accumulate in the flesh of fish and be eaten by people, making them extremely ill and killing them if they are eaten too much and too often.";
            SetAllText();
        }

        else if (elementSlider.value == 81)
        {
            atomicName = "Thallium";
            atomicSymbol = "Tl";
            atomicMass = 204.3833;
            atomicMelt = 577;
            atomicBoil = 1746;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 13;
            atomicDiscoverer = "William Crookes";
            atomicYear = 1861;
            atomicIon = 6.108;
            atomicDensity = 11.8;
            atomicIsotopes = 2;
            atomicInfo = "Thallium, from the Greek word for a green shoot or twig, thallos, was discovered when sludge that was left over from the production of sulfuric acid (H2SO4) was investigated. After the selenium was removed from the sludge, a spectroscope was used to look for tellurium, which produces yellow lines, but instead of that, green lines were detected, indicating that a new element was found in the sludge, which would later be named thallium. Today, thallium is found from the minerals crooksite (CuThSe), lorandite (TlAsS2) and hutchinsonite ((Pb, Tl)2As5S9), but it also obtained from refining zinc or lead.\n\nSince metallic thallium quickly combines with oxygen and water vapor in the air, forming a black, powdery material, there are no uses for it. However, thallium can alloy with sulfur, selenium and arsenic to form low melting glass. Thallium sulfate (Tl2SO4), a thallium compound, was once used as a rat and ant poison, although it has been banned from this use since 1974. Thallium sulfide (Tl2S), thallium iodide (TlI) and thallium bromide (TlBr) are used in devices that detect infrared radiation.\n\nThallium has no known biological roles, as it is very toxic and its vapor is carcinogenic and can disturb an embryo or fetus's development. It can displace potassium around the body, affecting the central nervous system.";
            SetAllText();
        }

        else if (elementSlider.value == 82)
        {
            atomicName = "Lead";
            atomicSymbol = "Pb";
            atomicMass = 207.2;
            atomicMelt = 600.61;
            atomicBoil = 2022;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 14;
            atomicDiscoverer = "N/A";
            atomicYear = 0;
            atomicIon = 7.417;
            atomicDensity = 11.342;
            atomicIsotopes = 3;
            atomicInfo = "Lead's name comes from the Anglo-Saxon word lead, but its chemical symbol comes from the Latin word for waterworks, plumbum.\n\nLead has been known since ancient times and is sometimes found free in nature, but is usually obtained from the ores galena (PbS), anglesite (PbSO4), cerussite (PbCO3) and minum (Pb3O4). Lead makes up about only 0.0013% of the Earth's crust, but it is not considered a rare earth element because it is easily mined and refined. Almost a third of all lead that is used in the United States is abtained through recycling efforts, while most of the rest is obtained by roasting galena in hot air.\n\nLead gets its chemical symbol from plumbum because the ancient Romans once used lead to make water pipes, some of which are still used today. Unfortunately, lead is a cumulative poison and has been partly blamed for the decline of the Roman empire. Today, lead is used to line tanks that store corrosive liquids such as sulfuric acid (H2SO4). Lead's high density makes it useful as a shield against X-ray and gamma ray radiation and it is therefore used in X-ray machines and nuclear reactors. Lead alloys with tin to make solder, a material that has a low melting point and is used to join electrical components, pipes and other metallic items together. Type metal, made from an alloy of lead, tin and antimony, is used in printing presses and plates. Babbit metal, another alloy of lead, is used for reducing friction in bearings. Lead monoxide (PbO), a compound of lead that is also known as litharge, is a yellow solid used for making some types of glass, vulcanizing rubber and coloring paint yellow. Lead sulfate (PbSO4), also known as anglesite, is used in a paint pigment known as sublimed white lead. Lead nitrate (Pb(NO3)2) is used for making fireworks and other pyrotechnics. Other lead compounds include lead carbonate (PbCO3), lead silicate (PbSiO3) and lead arsenate (Pb3(AsO4)2).\n\nIn addition to being toxic, lead is also carcinogenic and teratogenic, which means it can disturb an embryo or fetus's development. We consume an average of 0.1 milligrams of lead each day and store about 120 milligrams of lead in the bones.";
            SetAllText();
        }

        else if (elementSlider.value == 83)
        {
            atomicName = "Bismuth";
            atomicSymbol = "Bi";
            atomicMass = 208.9804;
            atomicMelt = 544.55;
            atomicBoil = 1837;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 15;
            atomicDiscoverer = "N/A";
            atomicYear = -1500;
            atomicIon = 7.289;
            atomicDensity = 9.807;
            atomicIsotopes = 0;
            atomicInfo = "Bismuth, whose name comes from the German words for white mass, \"Weisse Masse,\" which was later changed to Wisuth and Bisemutum, has been known since ancient times and was often confused with lead and tin. It occurs free in nature and in some minerals such as bismuthinite (Bi2S3) and bismite (Bi2O3). The largest deposits of bismuth are found in Bolivia, although it is more commonly obtained as a byproduct of mining and refining lead, copper, tin, silver and gold.\n\nPure bismuth is a white, brittle metal with a slight pink color. Bismuth forms low melting alloys with other metals such as lead, tin, iron, or cadmium. These alloys are used in automatic fire sprinkler systems and electrical fuses. Bismuth oxide (Bi2O3), a bismuth compound, is sometimes used as a yellow pigment in paints and beauty products. Bismuth oxychloride (BiOCl) is used to make a pigment known as bismuth white, while bismuth carbonate (Bi2(CO3)3) is used to treat diarrhea and gastric ulcers.\n\nBismuth-209 was thought to be the heaviest stable isotope to naturally occur, but in 2002, it was revealed to be unstable and decays into thallium-205 through alpha decay, where an atom's nucleus loses two protons and two neutrons in a packet known as an alpha particle. Bismuth 209's half-life is estimated to be 19 quintillion years. That's 19 with 18 zeroes following it (19,000,000,000,000,000,000).\n\nDespite bismuth's radioactivity, it is very, very minor and poses no great health or environmental risks.";
            SetAllText();
        }

        else if (elementSlider.value == 84)
        {
            atomicName = "Polonium";
            atomicSymbol = "Po";
            atomicMass = -209;
            atomicMelt = 527;
            atomicBoil = 1235;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 6;
            atomicGroup = 16;
            atomicDiscoverer = "Marie Curie";
            atomicYear = 1898;
            atomicIon = 8.417;
            atomicDensity = 9.32;
            atomicIsotopes = 0;
            atomicInfo = "Polonium, named after the country of Poland, was first obtained from pitchblende, a material that contains uranium, after it was discovered that the pitchblende is more radioactive than the uranium that was separated from it. The pitchblende was refined to produce polonium and radium. One ton of uranium ore contains about 0.0001 grams of polonium.\n\nUnfortunately, polonium is very scarce, so most of it has to be produced by bombarding bismuth-209 with neutrons in a nuclear reactor to make bismuth-210, which decays into polonium-210 through beta-minus decay after around 5 days. Polonium-210's half-life is around 138 days. A single gram of polonium-210 creates 140 Watts of heat energy and is being considered for use in spacecraft for thermoelectric power.\n\nPolonium's most stable isotope is polonium-209, with a half-life of 102 years. Polonium-209 decays into lead-205 through alpha decay. It is available frm the Oak Ridge National Laboratory at about $3,200 per microcurie. A microcurie is a unit of quantity or radioactivity equal to one millionth of a normal curie.\n\nPolonium may be used to remove static electricity that is caused through rolling paper, wire, or sheet metal, although that is more commonly used with other materials that emit beta radiation. Polonium is also used in brushed for removing dust from photographic films, but the polonium must be carefully sealed to avoid contaminating the user. It can also be combined with beryllium to form neutron sources to be used in nuclear reactors.\n\nPolonium is highly toxic due to its radioactivity, so it does not have any biological roles.";
            SetAllText();
        }

        else if (elementSlider.value == 85)
        {
            atomicName = "Astatine";
            atomicSymbol = "At";
            atomicMass = -210;
            atomicMelt = 575;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Halogen";
            atomicPeriod = 6;
            atomicGroup = 17;
            atomicDiscoverer = "Dale R. Carson, K.R. MacKenzie and Emilio Segre";
            atomicYear = 1940;
            atomicIon = 9.5;
            atomicDensity = 7;
            atomicIsotopes = 0;
            atomicInfo = "Astatine, from the Greek word for unstable, astatos, was first produced by bombarding bismuth-209 with alpha particles in a cyclotron at the University of California. This mombardment created astatine-211 and two free neutrons. Small amounts of astatine exist in nature from uranium and thorium decay, but because the total amount of astatine in the Earth's crust at any one time is less than 30 grams, it is only produced in cyclotrons when needed. Only 0.00000005 grams of astatine have been produced to date.\n\nAstatine's most stable isotope, astatine-210, has a half life on 8.1 hours and decays into bismuth-206 through alpha decay or polonium-210 through electron capture, where an electron in an atom's inner shell is drawn into the nucleus where it combines with a proton to form a neutron and a neutrino, and the neutrino is ejected from the nucleus afterwards. Because astatine has a short half-life, its only real use is for scientific research.\n\nAstatine is toxic due to its radioactivity, and because its half-life is less than half a day, it will never have any biological roles.";
            SetAllText();
        }

        else if (elementSlider.value == 86)
        {
            atomicName = "Radon";
            atomicSymbol = "Rn";
            atomicMass = -222;
            atomicMelt = 202;
            atomicBoil = 211.45;
            atomicPhase = "Solid";
            atomicClass = "Noble Gas";
            atomicPeriod = 6;
            atomicGroup = 18;
            atomicDiscoverer = "Friedrich Ernst Dorn";
            atomicYear = 1900;
            atomicIon = 10.745;
            atomicDensity = 0.00973;
            atomicIsotopes = 0;
            atomicInfo = "Radon, originally named niton after the Latin word for shining, nitens, but was later named after the element radium, is a colorless, odorless, radioactive gas that was discovered while the decay chain of radium was being studied. The most common forms of radon decay through alpha decay. Normally, alpha decay isn't a very big radiological hazard because the particles that come from the decay can easily be stopped, but since radon is a gas, it can be inhaled and cause some lung diseases, including lung cancer. Its most stable isotope is radon-22, with a half-life of 3.8 days, but even with a half-life that short, it decays into longer lived, solid, radioactive elements that can collect on dust particles and be inhaled too.\n\nThere is some concern over radon present within homes, as it seeps into houses due to the decay of radium, thorium, or uranium ores underneath, but this can vary from location to location.\n\nMinute amounts of radon are sometimes used in hospitals to treat some forms of cancer. The only confirmed compound of radon is radon fluoride (RnF), although it has no commercial uses.\n\nWhen radon cools into a solid state, it glows yellow. When the temperature is lowered further, the glow becomes an orange-red color.";
            SetAllText();
        }

        else if (elementSlider.value == 87)
        {
            atomicName = "Francium";
            atomicSymbol = "Fr";
            atomicMass = -223;
            atomicMelt = 300;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Alkali Metal";
            atomicPeriod = 7;
            atomicGroup = 1;
            atomicDiscoverer = "Marguerite Perey";
            atomicYear = 1939;
            atomicIon = 3.9;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Francium, named after the country of France, was discovered while analyzing actinium's decay. It is considered by scientists as a natural element, but there is no more than one ounce of francium in the Earth's crust at any one time. Because there is so little francium that occurs naturally, most of it is produced in cyclotrons for scientists to study it. Francium is produced by bombarding radium atoms with neutrons.\n\nFrancium's most stable isotope, francium-223, has a half-life of around 22 minutes. It decays through beta-minus decay into radium-223 or into astatine-219 through alpha decay.\n\nOther than basic research, there are no other uses for francium due to its low availability and short half-life, nor are there any known compounds.";
            SetAllText();
        }

        else if (elementSlider.value == 88)
        {
            atomicName = "Radium";
            atomicSymbol = "Ra";
            atomicMass = -226;
            atomicMelt = 973;
            atomicBoil = 1413;
            atomicPhase = "Solid";
            atomicClass = "Alkaline Earth Metal";
            atomicPeriod = 7;
            atomicGroup = 2;
            atomicDiscoverer = "Pierre Curie and Marie Curie";
            atomicYear = 1898;
            atomicIon = 5.279;
            atomicDensity = 5;
            atomicIsotopes = 0;
            atomicInfo = "Radium, from the Latin word for ray, radius, was discovered in a material called pitchblende after it was noticed that pitchblende is more radioactive than the uranium that was seperated from it. Several tons of pitchblende was refines in order to obtain tiny amounts of radium and polonium. One ton of uranium ore contains about 0.14 grams of radium. Today, it is obtained as a byproduct of refining uranium and is normally sold as radium chloride (RaCl2) or radium bromide (RaBr2) and not as a pure material.\n\nRadium's most stable isotope, radium-226, has a half-life of about 1,600 years. It decays into radon-222 through alpha decay or into lead-212 by ejecting a carbon-14 nucleus.\n\nRadium has been used to make self-luminous paints for watches and aircraft instrument dials, but has been replaced by cobalt-60 for these purposes, as it is a less dangerous radioactive source. A mixture of radium and beryllium will emit neutrons and is used as source of neutrons to be blasted at atoms to make new elements. Radium is also used to produce radon, a radioactive gas used to treat many forms of cancer.\n\nRadium is about a million times more radioactive than uranium. The lab notebooks used by the Curies are too contaminated with radium and other radioactive elements to be safely handled, even to this day.";
            SetAllText();
        }

        else if (elementSlider.value == 89)
        {
            atomicName = "Actinium";
            atomicSymbol = "Ac";
            atomicMass = -227;
            atomicMelt = 1324;
            atomicBoil = 3471;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Andrew Debierne";
            atomicYear = 1899;
            atomicIon = 5.17;
            atomicDensity = 10.07;
            atomicIsotopes = 0;
            atomicInfo = "Actinium, from the Greek word for a beam or ray, aktis, was discovered while new methods of separating rare earth oxides were being experimented. It is present in uranium ores in trace amounts, but it is usually cheaper to create artificial actinium by bombarding radium with neutrons in a nuclear reactor.\n\nActinium's most stable isotope is actinium-227, which has a half-life of 21.77 years. It decays into francium-223 via alpha decay or into thorium-227 through beta-minus decay.\n\nActinium is used for producing neutrons to bombard atoms with to make new elements, it has no other used because it is radioactive.";
            SetAllText();
        }

        else if (elementSlider.value == 90)
        {
            atomicName = "Thorium";
            atomicSymbol = "Th";
            atomicMass = 232.0377;
            atomicMelt = 2023;
            atomicBoil = 5061;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Jons Jacob Berzelius";
            atomicYear = 1829;
            atomicIon = 6.08;
            atomicDensity = 11.72;
            atomicIsotopes = 0;
            atomicInfo = "Thorium, named after the Scandinavian god of war, Thor, was discovered in a sample of thorite (ThSiO4), a mineral that was suspected to contain an unknown substance. Thorium makes up about 0.0007% of the Earth's crust and is primarily obtained from thorite, thorianite (ThO2) and monazite ((Ce, La, Th, Nd, Y)PO4).\n\nThorium alloys with magnesium to help it withstand higher temperatures and coats tungsten filaments that are used in electronic devices. Thorium oxide (ThO2), one of thorium's compounds, is used mainly in a type of lantern mantle known as a Welsbach mantle, named after Austrian chemist Carl Auer von Welsbach. A Welsbach mantle glows a bright white light when it is heated in a gas flame. Thorium oxide is also used to make high temperature crucibles, as it has a melting point of about 3300C. It is also for making glass with a high index of refraction for high quality camera lenses.\n\nThorium's most stable isotope is thorium-232, with a half-life of about 14.05 billion years. It decays into radium-228 through alpha decay, but when bombarded with neutrons, it becomes thorium-233, which decays into uranium-233 through a series of beta-minus decays.";
            SetAllText();
        }

        else if (elementSlider.value == 91)
        {
            atomicName = "Protactinium";
            atomicSymbol = "Pa";
            atomicMass = 231.0359;
            atomicMelt = 1845;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Kasimir Fajans and Otto Gohring";
            atomicYear = 1913;
            atomicIon = 5.89;
            atomicDensity = 15.37;
            atomicIsotopes = 0;
            atomicInfo = "Protactinium, from the Greek word for first, protos, and the element actinium, which mean \"the parent of actinium\" when put together, was first identified while the decay chain of uranium was being studied. One particular isotope that was found, protactinium-234m, has a half-life of about 1.17 minutes. The element was initially named brevium, meaning brief, but it was renamed protactinium after another of its isotopes, protactinium-231, was discovered.\n\nProtactinium is a rare, poisonous and expensive element that is present in uranium ores in trace amounts. The Great Britain Atomic Energy Authority was able to produce 125 grams of 99.9% pure protactinium in 1961, but they had to process about 55,000 kilograms of ore and spend about $500,000 to obtain it.\n\nProtactinium-231 is the most stable isotope of protactinium, with a half-life of 32,760 years. It decays intio actinium-227 through alpha decay.\n\nDue to protactinium's scarcity, radioactivity and toxicity, there are currently no uses for this element outside of basic scientific research.";
            SetAllText();
        }

        else if (elementSlider.value == 92)
        {
            atomicName = "Uranium";
            atomicSymbol = "U";
            atomicMass = 238.0289;
            atomicMelt = 1408;
            atomicBoil = 4404;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Martin Heinrich Klaproth";
            atomicYear = 1789;
            atomicIon = 6.194;
            atomicDensity = 18.95;
            atomicIsotopes = 0;
            atomicInfo = "Uranium, named after the planet Uranus, was discovered in the mineral pitchblende, which is primarily a mix of uranium oxides. Although it was believed that the substance that was extracted from pitchblende was pure uranium, it was actually uranium dioxide (UO2). The uranium dioxide was then heated with potassium in a platinum crucible to separate the uranium from the oxygen. Radioactivity was first discovered in a sample of uranium by French physicist Antoine Henri Becquerel in 1896. Today, uranium is obtained from pitchblende, uraninite (UO2), carnotite (K2(UO2)2VO4 * 1-3H2O), autunite (Ca(UO2)2(PO4)2 * 10H2O), phosphate rock (Ca3(PO4)2), lignite (brown coal) and monazite sand ((Ce, La, Th, Nd, Y)PO4), although it is ususally sold as diuranate (Na2U2O7·6H2O) or triuranium octoxide (U3O8) because demand for metallic uranium is quite low.\n\nBecause it is naturally radioactive, uranium is most commonly used in the nuclear power industry to generate electricity. There are three isotopes of uranium that exist naturally: uranium-234, uranium-235 and uranium-238, although only uranium-235 is a fissionable material used for nuclear power. When a fissionable material is struck with a neutron, its nucleus releases energy by splitting into smaller fragments. If some of these fragments are other neutrons, they can strike other atoms and cause them to split as well. Uranium-235 is capable of producing enough free neutrons to sustain a nuclear chain reaction.\n\nUnfortunately, only 0.7204% of all naturally occuring uranium is uranium-235. This is too low a concentration to sustain a nuclear chain without help from a material called a moderator, which can slow down a neutron without absorbing it. Slow neutrons are more likely to react with uranium-235 and reactors using natural uranium can be made using graphite or heavy water as moderators. Normal water can be used in place of the moderators after uranium-235 concentrations have increased to roughly 3%.\n\nUranium-238 is uranium's most common and stable isotope, with a half-life of about 4.468 billion years. Uranium-238 decays into thorium-234 via alpha decay. It can be converted into plutonium-239, which can also be used as fuel in nuclear reactors. To produce plutonium-239, uranium-238 atoms are bombarded with neutrons. When uranium-238 absorbs a neutron, it becomes uranium-239, which has a half-life of about 23 minutes and decays into neptunium-239 through beta-minus decay. Neptunium-239's half-life is approximately 2.4 days and decays through beta-minus decay into plutonium-239.\n\nUranium has few uses outside of the nuclear power industry. It is used as a target for X-ray production, as ammunition for some types of military weaponry, as a shield against radiation, as a counterweight for aircraft control surfaces and in gyroscopes for internal guidance systems. For centuries, it has been used to color glass yellow. There is a 2,00 year old sample of yellow glass near Naples, Italy, that contains uranium oxide. Uranium trioxide (UO3) is an orange powder and has been used in the manufacture of Fiestaware plates. Other uranium compounds have also been used to make vaseline glass and glazes, but the uranium within these items is radioactive and should be handled carefully.\n\nAs uranium is a radioactive substance, its health effects have been researched thoroughly. When people are exposed to uranium radionuclides that are formed during radioactive decay for long periods of time, they may develop cancer. When people are exposed to enriched uranium, the chances of getting cancer are much higher because it is more radioactive. Enriched uranium may end up in the environment during accidents in nuclear power plants such as the Chernobyl disaster in 1986, where at least 5% of the radioactive reactor core was released into the environment and spread throughout many parts of Europe after a steam explosion damaged the reactor.";
            SetAllText();
        }

        else if (elementSlider.value == 93)
        {
            atomicName = "Neptunium";
            atomicSymbol = "Np";
            atomicMass = -237;
            atomicMelt = 917;
            atomicBoil = 4175;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Edwin McMillan and Phillip Abelson";
            atomicYear = 1940;
            atomicIon = 6.266;
            atomicDensity = 20.25;
            atomicIsotopes = 0;
            atomicInfo = "Neptunium, named after the planet Neptune, was produced at the University of California in 1940 as neptunium-239 by bombarding uranium with slow moving neutrons. Neptunium-239 has a half-life of about 2.4 days.\n\nNeptunium was once considered to be completely artificial until it was discovered that extremely small amounts were made in uranium ores. This was done by interacting with uranium atoms in the ore with neutrons produced by the decay of other uranium atoms in the ore.\n\nNeptunium's most stable isotope is neptunium-237, with a half-life of about 2,144,000 years. It decays through alpha decay into protactinium-233. Neptunium-237 appears as a byproduct of producing plutonium in nuclear reactors and is used in neutron detectors.";
            SetAllText();
        }

        else if (elementSlider.value == 94)
        {
            atomicName = "Plutonium";
            atomicSymbol = "Pu";
            atomicMass = -244;
            atomicMelt = 913;
            atomicBoil = 3501;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Glenn Seaborg and co.";
            atomicYear = 1940;
            atomicIon = 6.06;
            atomicDensity = 19.84;
            atomicIsotopes = 0;
            atomicInfo = "Plutonium, named after the dwarf planet Pluto, was first produced by bombarding uranium-238 with deuterons, which are particles that consist of one proton and one neutron, in a cyclotron. This initially created neptunium-238 and two free neutrons, but after 2.1 days, the neptunium-238 decayed via beta-minus decay into plutonium-238. The discovery was not revealed to the public until 1946 due to the progression of World War II.\n\nWith a half-life of 82,000,000 years, plutonium-244 is plutonium's most stable isotope. It decays into uranium-240 via alpha decay.\n\nThere are only two isotopes of plutonium, plutonium-238, with a half-life of 87.7 years, and plutonium-239, with a half-life of 24,110 years, that have uses outside of scientific research. Plutonium-238 is used in radioisotope thermoelectric generators to provide electricity for space probes that venture too far from the sun to use solar power. Cassini and Galileo are two examples of probes that use these generators. Plutonium-239 is used in modern day nuclear weapons and in some nuclear reactors, but it will undergo a fission chain reaction if enough of it is concentrated in one place.";
            SetAllText();
        }

        else if (elementSlider.value == 95)
        {
            atomicName = "Americium";
            atomicSymbol = "Am";
            atomicMass = -243;
            atomicMelt = 1449;
            atomicBoil = 2284;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Glenn Seaborg and co.";
            atomicYear = 1944;
            atomicIon = 5.993;
            atomicDensity = 13.69;
            atomicIsotopes = 0;
            atomicInfo = "Americium, named after the Americas, was first produced by bombarding plutonium-239 with high energy neutrons to form plutonium-240, then plutonium-241, which decayed through beta-minus decay into americium-241.\n\nAmericium-243 is the most stable isotope of americium, with a half-life of 7,370 years. It decays into neptunium-239 through alpha decay.\n\nAmericium has a few practical uses outside of research. It is found in smoke detectors and is being considered as a possible source of gamma rays in portable devices. Americium-241, whose half-life is 432.2 years, is used in these products because it is easier to produce than many other americium isotopes.";
            SetAllText();
        }

        else if (elementSlider.value == 96)
        {
            atomicName = "Curium";
            atomicSymbol = "Cm";
            atomicMass = -247;
            atomicMelt = 1618;
            atomicBoil = 3400;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Glenn Seaborg and co.";
            atomicYear = 1944;
            atomicIon = 6.02;
            atomicDensity = 13.51;
            atomicIsotopes = 0;
            atomicInfo = "Curium, named after scientists Pierre and Marie Curie, was first produced at the University of California by bombarding plutonium-239 atoms with alpha particles in a cyclotron. This would resukt in atoms of curium-242 and a free neutron. Curium-242's half-life is about 163 days and 163 days and decays into plutonium-238 through alpha decay. Meanwhile, curium's most stable isotope, curium-247, has a half-life of about 15,600,000 years and decays into plutonium-243 via alpha decay.\n\nOnly milligram amounts of curium have ever been produced, so there are currently no commercial applications for this element. However, it might be used in radioisotope thermoelectric generators in the future.\n\nThere are a few curium compounds that have been produced by scientists. These compounds include curium dioxide (CmO2), curium bromide (CmBr3), curium chloride (CmCl3) and curium tetrafluoride (CmF4). Like with pure curium, these compounds do not have any uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 97)
        {
            atomicName = "Berkelium";
            atomicSymbol = "Bk";
            atomicMass = -247;
            atomicMelt = 1323;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Stanley Thompson and co.";
            atomicYear = 1949;
            atomicIon = 6.23;
            atomicDensity = 14;
            atomicIsotopes = 0;
            atomicInfo = "Berkelium, named after the city of Berkeley, California, was created through the bombardment of americium-241 with alpha particles. This created the isotope berkelium-243 and two free neutrons.\n\nBerkelium-247, with a half-life of about 1,380 years, is the most stable isotope of berkelium. It decays through alpha decay into americium-243.\n\nThe first visible amounts of berklium compounds include berkelium chloride (BkCl3), berkelium oxychloride (BkOCl), berkelium fluoride (BkF3) and berkelium dioxide (BkO2), which have all been studied and identified through X-ray diffraction.\n\nSince only small amounts of berkelium have ever been produced, it has no known uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 98)
        {
            atomicName = "Californium";
            atomicSymbol = "Cf";
            atomicMass = -251;
            atomicMelt = 1173;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Stanley Thompson and co.";
            atomicYear = 1950;
            atomicIon = 6.3;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Californium was named after the state and University of California, where the element was first created by bombarding atoms of curium-242 with helium ions via a cyclotron. This created the isotope californium-245, whose half-life is about 45 minutes, and a free neutron.\n\nThe most stable isotope of californium, with a half-life of about 898 years, is californium-251. It decays into curium-247 through alpha decay. Another isotope, californium-252, has a half-life of around 2.6 years, but it is a very strong neutron source. One microgram (0.000001 grams) of californium-252 produces roughly 170,000,000 neutrons per minute. Californium-252 is being used to identify gold and silver ores through a technique known as neutron activation and in devices known as neutron moisture gauges that are used to find water and oil bearing layers in oil wells.\n\nVery few californium atoms or compounds, such as californium oxide (CfO) and californium trichloride (CfCl3), have been produced and studied, so they do not have any uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 99)
        {
            atomicName = "Einsteinium";
            atomicSymbol = "Es";
            atomicMass = -252;
            atomicMelt = 1133;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Albert Ghiorso and co.";
            atomicYear = 1952;
            atomicIon = 6.42;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Einsteinium, named after the German scientist Albert Einstein, was discovered when the radioactive debris of the first hydrogen bomb detonation was studied. One of the isotopes that was found was einsteinium-253, which was produced by combining 15 neutrons with uranium-238. Einsteinium-253 has a half-life of around 20 days and underwent many beta-minus decays after it was found. Today, einsteinium is produced through a lengthy chain of nuclear reactions that involves bombarding each isotope in the chain with neutrons and allowing the resulting isotope to undergo beta-minus decay.\n\nEinsteinium's most stable isotope is einsteinium-252, with a half-life of 471.7 days. It decays into berkelium-248 through alpha decay or into californium-252 through electron capture.\n\nSmall amounts of einsteinium have ever been produced, so it has no uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 100)
        {
            atomicName = "Fermium";
            atomicSymbol = "Fm";
            atomicMass = -257;
            atomicMelt = 1800;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Albert Ghiorso and co.";
            atomicYear = 1953;
            atomicIon = 6.5;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Fermium, named after the nuclear physicist Enrico Fermi, was discovered when the radioactive debris of the first hydrogen bomb detonation was studied. One of the isotopes that was found was fermium-255, which was produced by combining 17 neutrons with uranium-238. Fermium-255 has a half-life of around 20 hours and underwent several beta-minus decays after it was found. Today, fermium is produced through a lengthy chain of nuclear reactions that involves bombarding each isotope in the chain with neutrons and allowing the resulting isotope to undergo beta-minus decay.\n\nFermium-257, with a half-life of 100.5 days, is the most stable fermium isotope. It decays via alpha decay into californium-253.\n\nOther than scientific research, there are no known uses for fermium due to its short half-life and the small amounts produced.";
            SetAllText();
        }

        else if (elementSlider.value == 101)
        {
            atomicName = "Mendelevium";
            atomicSymbol = "Md";
            atomicMass = -258;
            atomicMelt = 1100;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Albert Ghiorso and co.";
            atomicYear = 1955;
            atomicIon = 6.58;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Mendelevium, named after the Russian chemist Dimitri Mendeleyev, was produced at the University of California where atoms of einsteinium-253 were bombarded with helium ions in a cyclotron. This made mendelevium-256, whose half-life is about 77 minutes, and a free neutron.\n\nMendelevium's most stable isotope, with a half-life of about 51.5 days, is mendelevium-258. It decays into einsteinium-254 through alpha decay.\n\nOnly trace amounts of mendelevium have ever been produced, so it has no uses other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 102)
        {
            atomicName = "Nobelium";
            atomicSymbol = "No";
            atomicMass = -259;
            atomicMelt = 1100;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Georgy Flerov and Albert Ghiorso";
            atomicYear = 1963;
            atomicIon = 6.65;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Nobelium, named after the Swedish scientist and founder of the Nobel prize, was produced independently by bombarding curium atoms with carbon ions. Curium-244 was combined with carbon-13 to produce an isotope of nobelium that lasted about 10 minutes, while curium-246 was combined with carbon-12 to produce an isotope that lasted about 3 seconds.\n\nNobelium-259 is the most stable nobelium isotope, with a half-life of about 58 minutes. It decays into fermium-255 through alpha decay or into mendelevium-259 through electron capture.\n\nOnly small amounts of nobelium have ever been produced, so it has no uses other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 103)
        {
            atomicName = "Lawrencium";
            atomicSymbol = "Lr";
            atomicMass = -262;
            atomicMelt = 1900;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Actinoid";
            atomicPeriod = 7;
            atomicGroup = 0;
            atomicDiscoverer = "Georgy Flerov and Albert Ghiorso";
            atomicYear = 1965;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Lawrencium, named after the scientist and inventor of the cyclotron Ernest O. Lawrence, was produced in several different isotopes from bombarding some californium atoms with boron ions in a linear accelerators. However, there was confusion about which one isotope was created and detected by scientists.\n\nLawrencium's most stable isotope, lawrencium-262, has a half-life of about 4 hours and either decays into nobelium-262 via electron capture or mendelevium-258 through aplha decay.\n\nOnly tiny amounts of lawrencium have ever been created, so it has no uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 104)
        {
            atomicName = "Rutherfordium";
            atomicSymbol = "Rf";
            atomicMass = -263;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 4;
            atomicDiscoverer = "Georgy Flerov and Albert Ghiorso";
            atomicYear = 1964;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Rutherfordium, named after the scientist Ernest Rutherford, was produced as the isotopes rutherfordium-257, rutherfordium-258, rutherfordium-259, rutherfordium-260 and rutherfordium-261 by bombarding plutonium and californium atoms with neon and carbon ions, respectively.\n\nRutherfordium's most stable isotope is rutherfordium-263, with a half-life of about 10 minutes. It decays into other elements through spontaneous fission, which is where an atom of a very heavy element breaks down into smaller atoms, creating other elements and free neutrons in the process.\n\nBecause of rutherfordium's short half-life and the small amounts it was produced in, there are currently no uses for the element.";
            SetAllText();
        }

        else if (elementSlider.value == 105)
        {
            atomicName = "Dubnium";
            atomicSymbol = "Db";
            atomicMass = -268;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 5;
            atomicDiscoverer = "Various Berkeley and Dubna scientists";
            atomicYear = 1968;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Dubnium was named after the city of Dubna, Russia, where the element was first reported. It was produced by bombarding atoms of americium-243 with ions of neon-22 to form dubnium-260 and five free neutrons. Later, some atoms of californium-249 were bombarded with ions of nitrogen-15 to form atoms of dubnium-260 and four free neutrons.\n\nDubnium-268 is dubnium's most stable isotope, with a half-life of 32 hours. It decays through spontaneous fission.\n\nBecause so little dubnium was produced to date and it has a short half-life, there are no uses for it other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 106)
        {
            atomicName = "Seaborgium";
            atomicSymbol = "Sg";
            atomicMass = -271;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 6;
            atomicDiscoverer = "Albert Ghiorso and co.";
            atomicYear = 1974;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Seaborgium, named after the scientist and producer of several transuranium elements Glenn Seaborg, was first created by bombarding californium-249 atoms with oxygen-18 atoms in a machine known as the Super-Heavy Ion Linear Accelerator. This produced seaborgium-263 atoms and four free neutrons, but this isotope had a half-life of only about 1 second.\n\nSeaborgium's most stable isotope, seaborgium-271, has a half-life of about 2.4 minutes and decays into rutherfordium-267 through alpha decay.\n\nOnly a few atoms of seaborgium have ever been made, so it does not have any uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 107)
        {
            atomicName = "Bohrium";
            atomicSymbol = "Bh";
            atomicMass = -270;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 7;
            atomicDiscoverer = "Peter Armbruster and Gottfried Munzenberg";
            atomicYear = 1981;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Bohrium, named after the Danish atomic physicist Niels Bohr, was produced by bombarding some atoms of bismuth-209 with ions of chromium-54, but not much is known about the resulting isotope that was created.\n\nBohrium's most stable isotope, with a half-life of about 1 minute, is bohrium-270. It decays into dubnium-266 via alpha decay.\n\nVery few atoms of bohrium have ever been made, so it has no uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 108)
        {
            atomicName = "Hassium";
            atomicSymbol = "Hs";
            atomicMass = -270;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 8;
            atomicDiscoverer = "Peter Armbruster and Gottfried Munzenberg";
            atomicYear = 1984;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Hassium, whose name comes from the Latin word for the German state of Hessen, Hassias, was created by bombarding atoms of lead-208 with ions of iron-58 in a linear accelerator. This resulted in the isotope hassium-265, with a half-life of only 2 milliseconds, and a free neutron.\n\nHassium's most stable isotope, hassium-270, has a half-life of about 22 seconds and decays through alpha decay into seaborgium-266.\n\nSince only a trace abount of hassium have ever been produced, there are no uses for this element outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 109)
        {
            atomicName = "Meitnerium";
            atomicSymbol = "Mt";
            atomicMass = -278;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 9;
            atomicDiscoverer = "Peter Armbruster and Gottfried Munzenberg";
            atomicYear = 1982;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Meitnerium, named after the Austrian physicist Lise Meitner, was produced by bombarding bismuth-209 atoms with iron-58 atoms in a linear accelerator. This created meitnerium-266, whose half-life is 3.8 milliseconds, and a free neutron.\n\nMeitnerium's most stable isotope is meitnerium-278, with a half-life of about 8 seconds. It decays into bohrium-274 through alpha decay.\n\nSince only small amounts of meitnerium have ever been produced, it does not have any uses outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 110)
        {
            atomicName = "Darmstadtium";
            atomicSymbol = "Ds";
            atomicMass = -281;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 10;
            atomicDiscoverer = "Sigurd Hofmann and co.";
            atomicYear = 1994;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Darmstadtium, named after the city of Darmstadt, Germany, was created by bombarding atoms of lead with atoms of nickel in a linear accelerator. The isotope that was created as a result, darmstadtium-269, has a half-life of 0.17 milliseconds.\n\nDarmstadtium's most stable isotope is darmstadtium-281, whose half-life is about 20 seconds. Sometimes, it decays through alpha decay into hassium-277, while other times, it decays through spontaneous fission.\n\nVery few darmstadtium atoms have ever been created, so there are no uses for it outside of research.";
            SetAllText();
        }

        else if (elementSlider.value == 111)
        {
            atomicName = "Roentgenium";
            atomicSymbol = "Rg";
            atomicMass = -281;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 11;
            atomicDiscoverer = "Peter Armbruster and Gottfried Munzenberg";
            atomicYear = 1994;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Roentgenium, named after the German scientist Wilhelm Conrad Roentgen, was produced by bombarding bismuth-209 atoms with nickel-64 ions in a linear accelerator. This resulted in the creation of roentgenium-272, with a half-life of about 1.5 milliseconds, and a free neutron.\n\nRoentgenium's most stable isotope is roentgenium-281, with a half-life of about 26 seconds. It decays through spontaneous fusion into other elements.\n\nVery few atoms of roentgenium have ever been made, so it has no uses other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 112)
        {
            atomicName = "Copernicium";
            atomicSymbol = "Cn";
            atomicMass = -285;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 12;
            atomicDiscoverer = "Sigurd Hofmann and co.";
            atomicYear = 1996;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Copernicium was named after the Renaissance scientist Nicolaus Copernicus. Its chemical symbol was originally going to be Cp, but it was rejected because it was previously used for the element lutetium, which was renamed to cassiopeium in 1949 before getting its current name.\n\nCopernicium was produced by bombarding atoms of lead with ions of zinc in a linear accelerator. This created the isotope copernicium-277, with a half-life of about 0.24 milliseconds.\n\nCopernicium-285 is the most stable copernicium isotope, with a half-life of about 30 seconds. It decays through alpha decay into darmstadtium-281.\n\nOnly a few copernicium atoms have ever been produced, so it has no uses other than for research.";
            SetAllText();
        }

        else if (elementSlider.value == 113)
        {
            atomicName = "Nihonium";
            atomicSymbol = "Nh";
            atomicMass = -286;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 13;
            atomicDiscoverer = "RIKEN scientists";
            atomicYear = 2004;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Nihonium, from the Japanese word for Japan, Nihon, was created by accelerating zinc ions at about 10% the speed of light towards a bismuth target. Two nihonium atoms were created as a result, both of which decayed quickly into dubnium-262 via a series of alpha decays. The nihonium isotope that was created is unknown.\n\nNihonium-286, with a half-life of about 20 seconds, is nihonium's most stable isotope and decays through alpha decay into roentgenium-282.\n\nOnly two nihonium atoms have ever been created, so it has no uses other than for research.";
            SetAllText();
        }

        else if (elementSlider.value == 114)
        {
            atomicName = "Flerovium";
            atomicSymbol = "Fl";
            atomicMass = -289;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 14;
            atomicDiscoverer = "Various scientists";
            atomicYear = 1999;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Flerovium, named in honor of the Flerov Laboratory of Nuclear Reactions, was produced by bombarding atoms of plutonium with ions of calcium. The resulting isotope was flerovium-289, which has a half-life of about 970 milliseconds.\n\nFlerovium-289m is the most stable isotope of flerovium, with a half-life of about 2.7 seconds. It decays via alpha decay into copernicium-285.\n\nOnly a few atoms of flerovium have ever been produced, so it has no uses other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 115)
        {
            atomicName = "Moscovium";
            atomicSymbol = "Mc";
            atomicMass = -289;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 15;
            atomicDiscoverer = "Various scientists";
            atomicYear = 2010;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Moscovium, named after the Moscow region of Russia, was made in a cyclotron by bombarding atoms of americium-243 with ions of calcium-48. The resulting isotopes were moscovium-287, whose half-life is 32 milliseconds, and moscovium-288, whose half-life is 87 milliseconds. Both of these isotopes quickly decayed into other elements.\n\nMoscovium's most stable isotope, moscovium-289, has a half-life of about 220 milliseconds and decays into nihonium-285 through alpha decay.\n\nVery few moscovium atoms have ever been produced, so it has no uses other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 116)
        {
            atomicName = "Livermorium";
            atomicSymbol = "Lv";
            atomicMass = -293;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Post-Transition Metal";
            atomicPeriod = 7;
            atomicGroup = 16;
            atomicDiscoverer = "Various scientists";
            atomicYear = 2000;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Livermorium, named in honor of the Lawrence Livermore National Laboratory, was produced by bombarding atoms of curium-248 with ions of calcium-48. This produced livermorium-292, with a half-life of 0.6 milliseconds, and four free neutrons.\n\nLivermorium's most stable isotope, livermorium-293, has a half-life of about 53 milliseconds and decays into flerovium-289 through alpha decay.\n\nLivermorium has no uses outside of research due to very few atoms being produced.";
            SetAllText();
        }

        else if (elementSlider.value == 117)
        {
            atomicName = "Tennessine";
            atomicSymbol = "Ts";
            atomicMass = -294;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Solid";
            atomicClass = "Halogen";
            atomicPeriod = 7;
            atomicGroup = 17;
            atomicDiscoverer = "Various scientists";
            atomicYear = 2010;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Tennessine, named after the US state of Tennessee, was produced by bombarding atoms of berkelium-249 with ions of calcium-48, although the isotope that was created is unknown.\n\nTennessine's most stable isotope is tennessine-294, which has a half-life of about 80 milliseconds and decays into moscovium-290 via alpha decay.\n\nOnly a few atoms of tennessine have ever been produced, so there are no uses for it other than research.";
            SetAllText();
        }

        else if (elementSlider.value == 118)
        {
            atomicName = "Oganesson";
            atomicSymbol = "Og";
            atomicMass = -294;
            atomicMelt = 0;
            atomicBoil = 0;
            atomicPhase = "Gas";
            atomicClass = "Noble Gas";
            atomicPeriod = 7;
            atomicGroup = 18;
            atomicDiscoverer = "Various scientists";
            atomicYear = 2006;
            atomicIon = 0;
            atomicDensity = 0;
            atomicIsotopes = 0;
            atomicInfo = "Oganesson, named after the Russian nuclear physicist Yuri Oganessian, was produced by bombarding atoms of californium-249 with ions of calcium-48. After about 1,080 hours of calcium-48 irradiation, the result was three oganesson atoms and three free neutrons.\n\nOganesson-294, the isotope that resulted from the irradiation, is also oganesson's most stable isotope, with a half-life of 0.89 milliseconds. It decays into livermorium-290 through alpha decay.\n\nOnly a few atoms of oganesson have ever been made, so it has no uses outside of research.";
            SetAllText();
        }
    }
}
