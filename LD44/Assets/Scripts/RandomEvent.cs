using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvent : MonoBehaviour
{
    public GameObject[] eventWritten;
    public int numberOfEventsRequired = 7;
    public GameObject gOScreen;
    public int i;
    public int limit = 100;
    public GameObject currentScreen;
    public void ChangeScreen(string nextScreen){
        foreach (GameObject screen in eventWritten)
        {
            if(nextScreen.Equals(screen.name)){
                currentScreen.SetActive(false);
                screen.SetActive(true);
                currentScreen=screen;
                Utils.GetMasterUtils().currentScreen=screen;
            }
        }
    }
    public string ChooseRandomEvent(){
        int i=0;
        do{
        gOScreen = eventWritten[Random.Range(0, eventWritten.Length)];
        if(i>100){
            Debug.LogError("LOOP INFINITO DE RANDOM EVENT");
            break;
        }
        i++;
        }while(gOScreen.GetComponent<EventAttributes>().hasBeenUsed == true);
        
        print(gOScreen.name);
        gOScreen.GetComponent<EventAttributes>().hasBeenUsed = true;
        return gOScreen.name;
    }

    public static RandomEvent GetMasterUtils(){
        return GameObject.Find("RandomEvent").GetComponent<RandomEvent>();
    }
}
