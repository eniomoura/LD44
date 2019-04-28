using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespondAllInputs : MonoBehaviour
{
    public GameObject buttonsHolder;

    void Update()
    {
        if(Input.GetMouseButton(0)){
            Utils.GetMasterUtils().ChangeScreen("WorkDay");
            buttonsHolder.SetActive(true);
            //
        }
    }
}
