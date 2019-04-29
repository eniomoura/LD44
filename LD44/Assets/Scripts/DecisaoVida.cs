using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DecisaoVida : MonoBehaviour, IPointerClickHandler
{
    public int damage;
    public int hunger;
    public int sanity;
    public GameObject contadorVida;
    public GameObject consequencia;
    public ButtonsForWork changetime;
    public GameObject counthunger;
    public GameObject countsanity;
    public static Text textoVida;
    public static Text textofome;
    public static Text textosanidade;
    public static int vida;
    public static int fominha;
    public static int mente;
    public static int quantOpcoes;
    void Start()
    {
        contadorVida = GameObject.Find("contadorVida");
        counthunger = GameObject.Find("contadorfome");
        countsanity = GameObject.Find("contadorsanidade");
        consequencia = transform.parent.transform.GetChild(1).gameObject;
        changetime = GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>();
    }

    void Update()
    {
        textoVida = contadorVida.GetComponent<Text>();
        textofome = counthunger.GetComponent<Text>();
        textosanidade = countsanity.GetComponent<Text>();
        vida = int.Parse(textoVida.text);
        fominha = int.Parse(textofome.text);
        mente = int.Parse(textosanidade.text);
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        /* switch (name)
        {
            case "miojo":
                textoVida.text = (vida - 2).ToString();
                break;
            case "pizza":
                textoVida.text = (vida - 1).ToString();
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
        }*/
        textoVida.text = (vida - consequencia.GetComponent<Statchange>().health).ToString();
        textofome.text = (fominha - consequencia.GetComponent<Statchange>().hunger).ToString();
        textosanidade.text = (mente - consequencia.GetComponent<Statchange>().sanity).ToString();
        changetime.limitOfClicks -= consequencia.GetComponent<Statchange>().time; 
        ShowConsequencia();
        
    }

    void ShowConsequencia()
    {
        Text[] textos = transform.parent.parent.GetComponentsInChildren<Text>();
        foreach (Text texto in textos)
        {
            texto.enabled = false;
            RespondAllInputs.textToReset.Add(texto);
        }
        RespondAllInputs.resetarConsequencia = consequencia;
        consequencia.SetActive(true);
    }
}