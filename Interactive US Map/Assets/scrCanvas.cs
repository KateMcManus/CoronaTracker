using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scrCanvas : MonoBehaviour
{
    public Text txt_Display;

    void Awake()
    {
        //Get a reference to the text box that displays info
        txt_Display = GameObject.Find("txt_Display").GetComponent<Text>();
   
    }

    void Start()
    {
        //1 as placeholder for recovery data. May not be publicly available.
        //Initialize all info for all 50 states
        StateInfo Alabama = new StateInfo();
        Alabama.SetStats(22845, 755, 1, "Businesses open with social distancing restrictions.");
        StateInfo Alaska = new StateInfo();
        Alaska.SetStats(609, 11, 1, "Businesses open with social distancing restrictions. Out of state travelers must self quarantine for 2 weeks. No gatherings of over 20 people");
        StateInfo Arizona = new StateInfo();
        Arizona.SetStats(31267, 1135, 1, "Businesses open with social distancing restrictions.");
        StateInfo Arkansas = new StateInfo();
        Arkansas.SetStats(10816, 171, 1, "Most businesses open with social distancing restrictions. Bars, entertainment venues still closed. No public indoor gatherings of over 10 people (religious services exempt). International travellers must self quarantine for 2 weeks.");
        StateInfo California = new StateInfo();
        California.SetStats(143513, 4934, 1, "Nonessential businesses closed. Nonessential travel prohibited.");
        StateInfo Colorado = new StateInfo();
        Colorado.SetStats(28632, 1582, 1, "Businesses open with social distancing restrictions. Restaurants are dine out only. No public or private gatherings of over 10 people");
        StateInfo Connecticut = new StateInfo();
        Connecticut.SetStats(44461, 4146, 1, "Most businesses open with social distancing restrictions. Restaurants are outdoor seating only. No public gatherings of over 5 people (50 for religious services).");
        StateInfo Delaware = new StateInfo();
        Delaware.SetStats(10106, 414, 1, "Nonessential travel prohibited. Nonessential businesses remote work only. Restaurants dine out only. No gatherings of over 1o people. Out of state travellers must self isolate for 2 weeks.");
        StateInfo Florida = new StateInfo();
        Florida.SetStats(69069, 2848, 1, "Businesses open with social distancing restrictions, except bars. Travelers from hotspot areas must self isolate for 2 weeks.");
        StateInfo Georgia = new StateInfo();
        Georgia.SetStats(54973, 2375, 1, "Businesses open with social distancing restrictions, restrictions on gatherings at nonessential businesses. No gatherings of over 10 people.");
        StateInfo Hawaii = new StateInfo();
        Hawaii.SetStats(692, 17, 1, "Nonessential travel prohibited. Nonessential businesses closed or remote work only. Separate operatiing hours for high risk customers at all essential businesses. No gatherings of over 10 people. Travelers must self isolate for 2 weeks.");
        StateInfo Idaho = new StateInfo();
        Idaho.SetStats(3260, 85, 1, "Businesses open with social distancing restrictions. Restaurants are dine out only. Travelers must self isolate for 2 weeks.");
        StateInfo Illinois = new StateInfo();
        Illinois.SetStats(130603, 6185, 1, "Nonessential travel prohibited. Nonessential gatherings prohibited. No essentail gatherings over 10 people. Restaurants are dine out only.");
        StateInfo Indiana = new StateInfo();
        Indiana.SetStats(38748, 2380, 1, "Businesses open with social distancing restrictions. No gatherings of over 25 people (religous services exempt).");
        StateInfo Iowa = new StateInfo();
        Iowa.SetStats(22973, 640, 1, "Most businesses open with social distancing restrictions (casinos, campgrounds, amusement parks, salons are closed). No gatherings of over 10 people (religous services exempt).");
        StateInfo Kansas = new StateInfo();
        Kansas.SetStats(10838, 243, 1, "Most businesses open with social distancing restrictions (Gyms, bars, nightclubs, salons are closed). International travelers and travelers from hotspot areas must self isolate for 2 weeks.");
        StateInfo Kentucky = new StateInfo();
        Kentucky.SetStats(11945, 493, 1, "Nonessential businesses closed. Mass gatherings prohibited. Small gatherings allowed with social distancing.");
        StateInfo Louisiana = new StateInfo();
        Louisiana.SetStats(44472, 2987, 1, "Businesses open with social distancing restrictions.");
        StateInfo Maine = new StateInfo();
        Maine.SetStats(2667, 100, 1, "Nonessential travel prohibited. Nonessential businesses remote work only. No gatherings of over 10 people. Travelers must self isolate for 2 weeks.");
        StateInfo Maryland = new StateInfo();
        Maryland.SetStats(60197, 2875, 1, "Nonessential travel prohibited. Nonessential businesses remote work only. No gatherings of over 10 people. Travelers must self isolate for 2 weeks.");
        StateInfo Massachusetts = new StateInfo();
        Massachusetts.SetStats(104667, 7492, 1, "Nonessental businesses must remote work. No indoor gatherings of over 10 people. Travelers must self isolate for 2 weeks.");
        StateInfo Michigan = new StateInfo();
        Michigan.SetStats(65449, 5985, 1, "Nonessential travel prohibited. Nonessential businesses remote work only. No gatherings (religous services exempt). Restaurants are dine out only.");
        StateInfo Minnesota = new StateInfo();
        Minnesota.SetStats(29316, 1280, 1, "Businesses open with social distancing restrictions. No gathrings of over 10 people. Restaurants are dine out only.");
        StateInfo Mississippi = new StateInfo();
        Mississippi.SetStats(18483, 868, 1, "Businesses open with social distancing restrictions. No gathrings of over 10 people.");
        StateInfo Missouri = new StateInfo();
        Missouri.SetStats(15707, 862, 1, "Businesses open with social distancing restrictions.");
        StateInfo Montana = new StateInfo();
        Montana.SetStats(563, 18, 1, "Most businesses open with social distancing restrictions (places of assembly are closed). Nonwork travelers must self isolate for 2 weeks.");
        StateInfo Nebraska = new StateInfo();
        Nebraska.SetStats(16315, 212, 1, "Most businesses open with social distancing restrictions (bars and theaterss are closed). Masks required in salons. No gatherings of over 10 people (religious services exempt).");
        StateInfo Nevada = new StateInfo();
        Nevada.SetStats(10473, 459, 1, "Most businesses open with social distancing restrictions (recreational businesses closed).");
        StateInfo NewHampshire = new StateInfo();
        NewHampshire.SetStats(5209, 308, 1, "Nonessential travel prohibited. Nonessential businesses remote work only. No gatherings of over 9 people.");
        StateInfo NewJersey = new StateInfo();
        NewJersey.SetStats(165816, 12443, 1, "Nonessential travel prohibited. Nonessential businesses closed. No gatherings of over 10 people. Restaurants are dine out only.");
        StateInfo NewMexico = new StateInfo();
        NewMexico.SetStats(9367, 420, 1, "Nonessential travel prohibited. Masks required outside. Nonessential businesses remote work only. No gatherings of over 5 people per room. Restaurants are dine out only. Air travelers must self isolate for 2 weeks.");
        StateInfo NewYork = new StateInfo();
        NewYork.SetStats(380892, 30580, 1, "Nonessential gatherings prohibited. Nonessential businesses closed in NYC. Restaurants are dine out only.");
        StateInfo NorthCarolina = new StateInfo();
        NorthCarolina.SetStats(39584, 1106, 1, "No gatherings of over 10 people (religious gatherings and expressions of First Ammendment exempt). Most businesses open with social distancing restrictions (personal care and enter.");
        StateInfo NorthDakota = new StateInfo();
        NorthDakota.SetStats(2980, 74, 1, "Businesses open with social distancing restrictions. Travelers must self isolate for 2 weeks.");
        StateInfo Ohio = new StateInfo();
        Ohio.SetStats(40004, 2492, 1, "Nonessential travel prohibited. Businesses open with social distancing restrictions.");
        StateInfo Oklahoma = new StateInfo();
        Oklahoma.SetStats(7626, 358, 1, "Businesses open with social distancing restrictions.");
        StateInfo Oregon = new StateInfo();
        Oregon.SetStats(5237, 171, 1, "Nonessential travel prohibited. No gatherings of over 25 people. Restaurants are dine out only.");
        StateInfo Pennsylvania = new StateInfo();
        Pennsylvania.SetStats(81848, 6113, 1, "Nonessential travel prohibited. Most businesses closed or remote work only. Restaurants are dine out only.");
        StateInfo RhodeIsland = new StateInfo();
        RhodeIsland.SetStats(15862, 823, 1, "No gatherings of over 9 people. Travelers must self isoloate for 2 weeks. Restaurants are dine out only.");
        StateInfo SouthCarolina = new StateInfo();
        SouthCarolina.SetStats(16441, 588, 1, "No gatherings of over 3 people. Nonessential businesses remote work only. Restaurants open with social distancing restrictions.");
        StateInfo SouthDakota = new StateInfo();
        SouthDakota.SetStats(5665, 73, 1, "Businesses open with social distancing restrictions.");
        StateInfo Tennessee = new StateInfo();
        Tennessee.SetStats(28340, 441, 1, "No gatherings of over 10 people (religous services exempt). Businesses open with social distancing restrictions.");
        StateInfo Texas = new StateInfo();
        Texas.SetStats(82658, 1930, 1, "Businesses open with social distancing restrictions. Travelers from hot spot areas must self isolate for 2 weeks.");
        StateInfo Utah = new StateInfo();
        Utah.SetStats(13252, 131, 1, "No gatherings of over 20 people. Businesses open with social distancing restrictions. Travelers from hot spot areas must self isolate for 2 weeks.");
        StateInfo Vermont = new StateInfo();
        Vermont.SetStats(1110, 55, 1, "No gatherings of over 10 people. Businesses open with social distancing restrictions. Restaurants are dine out only. Travelers must self isolate for 2 weeks.");
        StateInfo Virginia = new StateInfo();
        Virginia.SetStats(52647, 1520, 1, "Nonessential travel prohibited. No gatherings over 10 people. Most businesses open with social distancung restrictions (no recreation). Restaurants are dine out only.");
        StateInfo Washington = new StateInfo();
        Washington.SetStats(24779, 1194, 1, "Nonessential travel prohibited. All gatherings prohibited. Nonessential businesses closed or limited. Restaurants are dine out only.");
        StateInfo WestVirginia = new StateInfo();
        WestVirginia.SetStats(2217, 86, 1, "No gatherings of over 25 people. Small businesses open with social distancing restrictions. Restaurants are outdoor seating only. Travelers must self isolate for 2 weeks.");
        StateInfo Wisconsin = new StateInfo();
        Wisconsin.SetStats(21926, 682, 1, "No statewide restrictions.");
        StateInfo Wyoming = new StateInfo();
        Wyoming.SetStats(1009, 18, 1, "No gatherings over 9 people. Entertainment venues closed. Non-work travelers must self isolate for 2 weeks. Restaurants are dine out only.");
    }

//Called when a state is clicked, currently only displays the name
//TODO: Display correct data
    public void ButtonPress()
    {
        string statename = EventSystem.current.currentSelectedGameObject.name;
        txt_Display.text = $"{statename}: ";

    }
 
}

//Class that holds the state info, each state is an object
public class StateInfo
{
    public int Cases;
    public int Deaths;
    public int Recoveries;
    public string Restrictions;

    public StateInfo()
    {
        int Cases = 0;
        int Deaths = 0;
        int Recoveries = 0;
        string Restrictions = "No restrictions";
    }

    public void SetStats(int cases, int deaths, int recoveries, string restrictions)
    {
        Cases = cases;
        Deaths = deaths;
        Recoveries = recoveries; //Maybe remove recoveries? I can't find that data.
        Restrictions = restrictions;
    }
}