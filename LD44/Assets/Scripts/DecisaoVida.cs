using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DecisaoVida : MonoBehaviour, IPointerClickHandler {
    GameObject contadorVida;
    Text textoVida;
    int vida;

    void Start () {
        contadorVida = GameObject.Find ("contadorVida");
    }

    void Update () {
        textoVida = contadorVida.GetComponent<Text> ();
        vida = int.Parse (textoVida.text);
    }

    public void OnPointerClick (PointerEventData pointerEventData) {
        switch (name) {
            case "miojo":
                textoVida.text = (vida - 50).ToString ();
                break;
            case "pizza":
                textoVida.text = (vida - 50).ToString ();
                break;
            case "ifood":
                textoVida.text = (vida - 50).ToString ();
                break;
            case "restaurante":
                textoVida.text = (vida - 50).ToString ();
                break;
            default:
                break;
        }
    }
}