using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameName : MonoBehaviour
{
    public static string gameName;
    public InputField input;

    void Update(){
        if(Input.GetKey(KeyCode.Return)){
            gameName = input.text;
            GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().limitOfClicks = 4;
            GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().i = 0;
            Utils.GetMasterUtils().ChangeScreen(RandomEvent.GetMasterUtils().ChooseRandomEvent());
        }
    }
}
