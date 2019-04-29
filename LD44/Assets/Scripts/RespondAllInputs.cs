using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class RespondAllInputs : MonoBehaviour
{
    public static List<Text> textToReset = new List<Text>();
    public static GameObject resetarConsequencia;

    void Update()
    {
        //WORKDAY START
        if (Input.GetMouseButtonDown(0) || Input.anyKey)
        {
            if (transform.parent.parent.parent.name.Equals("EndOfDay"))
            {
                RandomEvent.GetMasterUtils().ChangeScreen(RandomEvent.GetMasterUtils().ChooseRandomEvent());
                Utils.GetMasterUtils().GetComponent<Utils>().dia++;
            }
            else
            {
                Utils.GetMasterUtils().ChangeScreen("WorkDay");
            }
            ResetEndOfDay();
        }
    }

    void ResetEndOfDay()
    {
        gameObject.SetActive(false);
        foreach (Text texto in textToReset)
        {
            texto.enabled = true;
        }
        RespondAllInputs.textToReset = new List<Text>();
    }
}
