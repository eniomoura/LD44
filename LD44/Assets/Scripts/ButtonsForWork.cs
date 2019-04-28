using UnityEngine;
using UnityEngine.UI;

public class ButtonsForWork : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button b_gameDesign, b_programming, b_art, b_soundEffect, b_confirm;
    public int limitOfClicks = 4;
    public int gameDesign = 0;
    public int programming = 0;
    public int art = 0;
    public int soundEffect = 0;
    public int addValue = 20;
    public int i = 0;
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        b_gameDesign.onClick.AddListener(AddGameDesign);
        b_programming.onClick.AddListener(AddProgramming);
        b_art.onClick.AddListener(AddArt);
        b_soundEffect.onClick.AddListener(AddSoundEffect);
        b_confirm.onClick.AddListener(Confirm);
    }

    void Update() {
        Text botaoConfirma = b_confirm.GetComponentInChildren<Text>();
        if(i<limitOfClicks){
            botaoConfirma.text = "Cochila";
        }else{
            botaoConfirma.text = "Dormir";
        }
    }

    void AddGameDesign()
    {
        if(i<limitOfClicks){
            gameDesign += addValue;
            i++;
            print(gameDesign);
        
        }
    }

    void AddProgramming()
    {
        if(i<limitOfClicks){
            programming += addValue;
            i++;
            print(programming);
        }
    }

    void AddArt()
    {
        if(i<limitOfClicks){
            art += addValue;
            i++;
            print(art);
        }
    }

    void AddSoundEffect()
    {
        if(i<limitOfClicks){
            soundEffect += addValue;
            i++;
            print(soundEffect);
        }
    }
    void Confirm()
    {
        if(i>=limitOfClicks){
            Utils.GetMasterUtils().ChangeScreen(Utils.GetMasterUtils().ChooseRandomEvent());
            GameObject.Find("ButtonsHolder").SetActive(false);
        }else{
            DecisaoVida.textoVida.text=(DecisaoVida.vida+2).ToString();
            DecisaoVida.vida=int.Parse(DecisaoVida.textoVida.text);
            i++;
        }
    }
}