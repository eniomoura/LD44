using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour {
    public GameObject currentScreen;
    public GameObject[] screens;

    public void ChangeScreen (string nextScreen) {
        foreach (GameObject screen in screens) {
            if (nextScreen.Equals (screen.name)) {
                currentScreen.SetActive (false);
                currentScreen = screen;
                screen.SetActive (true);
            }
        }
    }

    public static Utils GetMasterUtils () {
        return GameObject.Find ("Master").GetComponent<Utils> ();
    }
}