using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespondAllInputs : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Utils.GetMasterUtils().ChangeScreen("WorkDay");
        }
    }
}
