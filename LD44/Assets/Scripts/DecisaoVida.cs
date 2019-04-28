using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DecisaoVida : MonoBehaviour, IPointerClickHandler
{
    public int damage;
    public GameObject contadorVida;
    public GameObject consequencia;
    public static Text textoVida;
    public static int vida;

    void Start()
    {
        contadorVida = GameObject.Find("contadorVida");
        consequencia = transform.parent.transform.GetChild(1).gameObject;
    }

    void Update()
    {
        textoVida = contadorVida.GetComponent<Text>();
        vida = int.Parse(textoVida.text);
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        switch (name)
        {
            case "miojo":
                textoVida.text = (vida - damage).ToString();
                break;
            case "pizza":
                textoVida.text = (vida - damage).ToString();
                break;
            case "junk":
                textoVida.text = (vida - damage).ToString();
                break;
            case "cook":
                break;
            case "sleep":
                textoVida.text = (vida - damage).ToString();
                break;
            case "eat":
                break;
            case "allnight":
                textoVida.text = (vida - damage).ToString();
                break;
            default:
                break;
        }
        ShowConsequencia();
    }

    void ShowConsequencia(){
        Text[] textos = transform.parent.parent.GetComponentsInChildren<Text>();
        foreach(Text texto in textos){
            texto.enabled=false;
        }
        consequencia.SetActive(true);
    }
}