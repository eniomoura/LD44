using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject[] screens;
    public GameObject gOScreen;
    public GameObject[] usedEvents;
    public int i;
    public void ChangeScreen(string nextScreen){
        foreach (GameObject screen in screens)
        {
            if(nextScreen.Equals(screen.name)){
                currentScreen.SetActive(false);
                screen.SetActive(true);
                currentScreen=screen;
            }
        }
    }

    public static Utils GetMasterUtils(){
        return GameObject.Find("Master").GetComponent<Utils>();
    }

    public string ChooseRandomEvent(){
        do{
        gOScreen = screens[Random.Range(2, screens.Length)];
        }while(gOScreen.GetComponent<EventAttributes>().hasBeenUsed == true);
        print(gOScreen.name);
        gOScreen.GetComponent<EventAttributes>().hasBeenUsed = true;
        return gOScreen.name;
    }
}
