using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject[] screens;
    public GameObject[] usedEvents;
    public int dia=1;
    public int i;
    public void ChangeScreen(string nextScreen){
        foreach (GameObject screen in screens)
        {
            if(nextScreen.Equals(screen.name)){
                currentScreen.SetActive(false);
                screen.SetActive(true);
                currentScreen=screen;
                RandomEvent.GetMasterUtils().currentScreen=screen;
            }
        }
    }

    public static Utils GetMasterUtils(){
        return GameObject.Find("Master").GetComponent<Utils>();
    }

    public static void RestartGame(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }
}