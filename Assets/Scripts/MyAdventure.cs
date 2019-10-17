using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // states geven aan in welke staat je game is zodat sommige commands niet meer werken
    private enum states
    {
        start,
        intro,
        chapter1,
        chapter2,
        chapter3,
        chapter4,
        chapter5,
        chapter6,
        reset,

    }
    private states currentState = states.start;
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Survive The Attack");
        Terminal.WriteLine("Dit is een horror spel");
        Terminal.WriteLine("Typ start om te beginnen");
        Terminal.WriteLine("");
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case states.start:
                if (input.ToLower() == "start")
                {
                    currentState = states.intro;
                    StartIntro();
                }
                else if (input.ToLower() == "1304")
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Gefeliciteerd, je hebt me gevonden. Ik ben de coder van de game!");
                    Terminal.WriteLine("");
                    Terminal.WriteLine("Typ Menu om terug te gaan of typ Start om te beginnen");
                    Terminal.WriteLine("");
                }
                else if (input.ToLower() == "menu")
                {
                    currentState = states.start;
                    ShowMainMenu();
                }
                else
                {
                    Terminal.WriteLine("Nee, typ start knuppel!");
                }
                break;
            case states.intro:
                if (input.ToLower() == "verder")
                {
                    currentState = states.chapter1;
                    NextChapter();
                }
                break;
            case states.chapter1:
                if (input.ToLower() == "beneden")
                {
                    currentState = states.chapter2;
                    NextChapter2();
                }
                else if (input.ToLower() == "raam")
                {
                    currentState = states.chapter3;
                    NextChapter3();
                }
                break;
            case states.chapter2:
                if (input.ToLower() == "aanvallen")
                {
                    currentState = states.reset;
                    dood1();
                }
                else if (input.ToLower() == "rennen")
                {
                    currentState = states.reset;
                    dood2();
                }
                break;
            case states.chapter3:
                if (input.ToLower() == "wachten")
                {
                    currentState = states.reset;
                    dood3();
                }
                else if (input.ToLower() == "wegjagen")
                {
                    currentState = states.reset;
                    win1();
                }
                else if (input.ToLower() == "politie")
                {
                    currentState = states.chapter4;
                    NextChapter4();
                }
                break;
            case states.chapter4:
                if (input.ToLower() == "verstoppen")
                {
                    currentState = states.chapter5;
                    NextChapter5();
                }
                else if (input.ToLower() == "vluchten")
                {
                    currentState = states.reset;
                    dood4();
                }
                break;
            case states.chapter5:
                if (input.ToLower() == "signaleren")
                {
                    currentState = states.reset;
                    win2();
                }
                else if (input.ToLower() == "klimmen")
                {
                    currentState = states.reset;
                    dood5();
                }
                else if (input.ToLower() == "afleiden")
                {
                    currentState = states.chapter6;
                    NextChapter6();
                }
                break;
            case states.chapter6:
                if (input.ToLower() == "vechten")
                {
                    currentState = states.reset;
                    dood6();
                }
                else if (input.ToLower() == "overgeven")
                {
                    currentState = states.reset;
                    win3();
                }
                break;
            case states.reset:
                if (input.ToLower() == "menu")
                {
                    currentState = states.start;
                    ShowMainMenu();
                }
                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is een koude avond als je zit te gamen met een aantal vrienden.");
        Terminal.WriteLine("Opeens hoor je een geluid in de achtertuin. Eerst een soort geritsel, daarna voetstappen. ");
        Terminal.WriteLine("Je had niemand uitgenodigd toch?");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'verder' om door te gaan");
        currentState = states.intro;
    }
    void NextChapter()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je komt er achter dat iemand probeert in te breken. Je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.	Naar beneden te gaan om te kijken wie het is");
        Terminal.WriteLine("2.	Uit je raam te kijken of je wat ziet");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ 'beneden' voor optie 1, en 'raam' voor optie 2");
        currentState = states.chapter1;
    }
    void NextChapter2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt naar beneden, en richting de achterdeur");
        Terminal.WriteLine("Je ziet iemand die je deur heeft geforceerd, hij ziet jou niet. Je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.  Hem aan te vallen");
        Terminal.WriteLine("2.  Om terug te rennen naar boven");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'aanvallen' voor optie 1, en 'rennen' voor optie 2");
        currentState = states.chapter2;
    }
    void NextChapter3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kijkt uit het raam neer beneden");
        Terminal.WriteLine("Je ziet nog net een persoon naar binnen gaan en hoort hem beneden lopen, je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.  Te wachten tot hij weg gaat en verstopt je");
        Terminal.WriteLine("2.  Hem proberen weg te jagen door te doen of er veel mensen aanwezig zijn");
        Terminal.WriteLine("3.	De politie bellen");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ 'wachten' voor optie 1, 'wegjagen' voor optie 2 en 'politie' voor optie 3");
        currentState = states.chapter3;
    }
    void NextChapter4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je belt de politie");
        Terminal.WriteLine("De assistente noteerd je gegevens en stuurt 2 auto's");
        Terminal.WriteLine("Ondertussen kan je je beter gedeisd houden zegt ze. Je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.  Je te verstoppen in de kast");
        Terminal.WriteLine("2.  Te vluchten");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'verstoppen' voor optie 1 of 'vluchten' voor optie 2");
    }
    void NextChapter5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De politie arriveerd in de straat");
        Terminal.WriteLine("Ze rijden wat langzaam opzoek naar je huis");
        Terminal.WriteLine("Je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.  Uit het raam te hangen en ze te signaleren");
        Terminal.WriteLine("2.  Uit het raam te klimmen");
        Terminal.WriteLine("3.  Naar beneden te gaan om de inbreker af te leiden");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'signaleren' voor optie 1, 'klimmen' voor optie 2 of 'afleiden' voor optie 3");
    }
    void NextChapter6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je loopt naar beneden om de inbreker af te leiden");
        Terminal.WriteLine("Je loopt naar hem toe en vraagt wat hij aan het doen is");
        Terminal.WriteLine("Hij kijkt verschrikt om. Op dat moment valt de politie binnen");
        Terminal.WriteLine("De inbreker schrikt en in paniek gijzeld hij jou. Je besluit:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1.  Terug te vechten");
        Terminal.WriteLine("2.  Je over te geven en rustig te blijven");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ 'vechten' voor optie 1 of 'overgeven' optie 2");
    }
    void dood1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent naar de inbreker toe om hem te tacklen");
        Terminal.WriteLine("Maar helaas draagt deze een vuurwapen");
        Terminal.WriteLine("Uit paniek vuurt hij het wapen in jou richting");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void dood2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent als een gek terug naar boven");
        Terminal.WriteLine("Maar net als je boven bent ren je jezelf voorbij");
        Terminal.WriteLine("Je verliest je evenwicht en valt naar beneden");
        Terminal.WriteLine("Je komt helaas heel ongelukkig terecht en breek je nek");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void dood3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je verstopt je in de kast en wacht af tot de inbreker klaar is en weg gaat");
        Terminal.WriteLine("De inbreker kijkt wat hij boven nog kan pakken");
        Terminal.WriteLine("Op dit ongelukkige moment moet je net niesen");
        Terminal.WriteLine("De inbreker ontdekt je. En die wil helaas geen ooggetuigen");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void dood4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besluit te gaan vluchten voor je leven");
        Terminal.WriteLine("Je rent als een gek naar beneden en naar de voordeur");
        Terminal.WriteLine("Op slot! nee he. En de inbreker heeft je ontdekt!");
        Terminal.WriteLine("Je probeert nog door de deur te trappen en rammen, maar tevergeefs");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void dood5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet de politie aankomen en probeert uit het raam te klimmen om naar ze toe te rennen");
        Terminal.WriteLine("Alleen is het je grote pech dat het geregent heeft en dus zijn de dakpannen nat en glad");
        Terminal.WriteLine("Je glijdt uit en valt naar beneden");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void dood6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je word gegijzeld en de inbreker zet een vuurwapen tegen je hoofd");
        Terminal.WriteLine("Je besluit dat je hier niet veel zin in hebt en vecht terug");
        Terminal.WriteLine("Door je onverwachte bewegingen gaat in paniek het vuurwapen af");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOOD");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void win1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besluit veel lawaai te maken alsof er veel mensen boven zijn");
        Terminal.WriteLine("De inbreker schrikt hier van en rent snel weg");
        Terminal.WriteLine("");
        Terminal.WriteLine("SLIM EINDE");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void win2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besluit de politie te signaleren vanuit je raam");
        Terminal.WriteLine("De agenten zien je signaleren en rennen naar binnen en arresteren de inbreker");
        Terminal.WriteLine("");
        Terminal.WriteLine("GELOOFWAARIG EINDE");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
    void win3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je word gegijzeld en de inbreker zet een vuurwapen tegen je hoofd");
        Terminal.WriteLine("Je besluit je rustig te houden en niet tegen te werken");
        Terminal.WriteLine("Na enig gepraat besluiten de agenten de inbreker neer te schieten");
        Terminal.WriteLine("");
        Terminal.WriteLine("GEWELDADIG EINDE");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'menu' om terug te gaan naar het hoofdmenu");
    }
}
