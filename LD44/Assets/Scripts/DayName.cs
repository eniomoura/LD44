using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayName : MonoBehaviour {

    Text textO;

    void Start(){
        textO = GetComponent<Text> ();
    }

    void Update () {
        if(textO!=null){
            if (Utils.GetMasterUtils().currentScreen.name.Equals("EndOfDay")) {
                textO.text = "END OF DAY " + Utils.GetMasterUtils().GetComponent<Utils>().dia;
            } else {
            textO.text = "DAY " + Utils.GetMasterUtils().GetComponent<Utils>().dia;
            }
        }
    }
}