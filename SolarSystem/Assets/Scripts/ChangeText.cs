using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField]
   
    public Text InformationPlanet;
    public GameObject target;

    string[] TextInformation = new string[]
    {
        "Sun\nMass: 1989000*10^24 kg\nDiametr: 1392700 km\nGravity: 274 m/s^2",//sun
        "Mercury\nMass: 0.32868*10^24 kg\nDiametr: 4878,4 km\nGravity: 274 m/s^2\nDistance form Sun 58 mio km",//Mercury
        "Venus\nMass: 4.81068*10^24 kg\nDiametr: 12104 km\nGravity: 3.7 m/s^2\nDistance form Sun 58 mio km",//Venus
        "Earth\nMass: 5.97600*10^24 kg\nDiametr: 12742 km\nGravity: 8.87 m/s^2\nDistance form Sun 150 mio km",//Earth
        "Moon\nMass: 7,35*10^22 kg\nDiametr: 3474.8km\nGravity: 1.62 m/s^2\nDistance form Earth 384400 km",//Moons
        "Mars\nMass: 0.63345*10^24 kg\nDiametr: 6779 km\nGravity: 3.71 m/s^2\nDistance form Sun 228 mio km",//Mars
        "Jupiter\nMass: 1876.64328*10^24 kg\nDiametr: 139820 km\nGravity: 24.79 m/s^2\nDistance form Sun 778 mio km",//Jupiter
        "Saturn\nMass: 561.80376*10^24 kg\nDiametr: 116460 km\nGravity: 10.44 m/s^2\nDistance form Sun 1429 mio km",//Saturn
        "Uranus\nMass: 86.05440*10^24 kg\nDiametr: 50724 km\nGravity: 8.87 m/s^2\nDistance form Sun 2875 mio km",//Uranus
        "Neptune\nMass: 101.59200*10^24 kg\nDiametr: 49244 km\nGravity: 11.15 m/s^2\nDistance form Sun 4497 mio km"//Neptune
    };
    string[] NamePlanets = new string[]
    {
        "Sun", "Mercury", "Venus", "Earth", "Moon", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
    };
    void Start()
    {
        
        InformationPlanet.text = "";
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LookAt.target = null;
          
            InformationPlanet.text = "";
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            InformationPlanet.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            InformationPlanet.enabled = true;
        }
    }

    void OnMouseDown()
    {
        LookAt.target = target;
        for (int planetname = 0; planetname < NamePlanets.Length; planetname++)
        {
            if(target.name == NamePlanets[planetname])
            {
                InformationPlanet.text = TextInformation[planetname];
            }
        }
    }

}
