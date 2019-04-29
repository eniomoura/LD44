using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonsForWork : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button b_gameDesign, b_programming, b_art, b_soundEffect, b_confirm, b_testbutton, b_replaybutton;
    public int limitOfClicks = 4;
    public int gameDesign = 0;
    public int programming = 0;
    public int art = 0;
    public int soundEffect = 0;
    public int addValue = 20;
    public int i = 0;
    public Text music;
    public Text artsdesign;
    public Text program;

    public Text design;
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        b_gameDesign.onClick.AddListener(AddGameDesign);
        b_programming.onClick.AddListener(AddProgramming);
        b_art.onClick.AddListener(AddArt);
        b_soundEffect.onClick.AddListener(AddSoundEffect);
        b_confirm.onClick.AddListener(Confirm);
        b_replaybutton.onClick.AddListener(Repeat);
    }

    void Update()
    {
    }

    void AddGameDesign()
    {
        if (i < limitOfClicks)
        {
            gameDesign += addValue;
            i++;
            print(gameDesign);
            design.text = gameDesign.ToString();

        }
    }

    void AddProgramming()
    {
        if (i < limitOfClicks)
        {
            programming += addValue;
            i++;
            print(programming);
            program.text = programming.ToString();
        }
    }

    void AddArt()
    {
        if (i < limitOfClicks)
        {
            art += addValue;
            i++;
            print(art);
            artsdesign.text = art.ToString();
        }
    }

    void AddSoundEffect()
    {
        if (i < limitOfClicks)
        {
            soundEffect += addValue;
            i++;
            print(soundEffect);
            music.text = soundEffect.ToString();
        }
    }

    void StartRandomEvent()
    {
        Utils.GetMasterUtils().ChangeScreen("ResultScreen");
    }
    void Confirm()
    {
        if (i >= limitOfClicks)
        {
            // Utils.GetMasterUtils().ChangeScreen(Utils.GetMasterUtils().ChooseRandomEvent());
            if (Utils.GetMasterUtils().GetComponent<Utils>().dia > 3)
            {
                Utils.GetMasterUtils().ChangeScreen("ResultScreen");
                GameObject.Find("iconeVida").SetActive(false);
                GameObject.Find("contadorVida").SetActive(false);
                GameObject.Find("iconeSanidade").SetActive(false);
                GameObject.Find("contadorsanidade").SetActive(false);
                GameObject.Find("iconecomida").SetActive(false);
                GameObject.Find("contadorfome").SetActive(false);
            }
            else
            {
                Utils.GetMasterUtils().ChangeScreen("EndOfDay");
                limitOfClicks = 4;
                i = 0;
            }
        }
        else
        {
            DecisaoVida.textoVida.text = (DecisaoVida.vida + 2).ToString();
            DecisaoVida.vida = int.Parse(DecisaoVida.textoVida.text);
            i++;
        }
    }
    void Repeat()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public static int GetProgramming(){
        return GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().programming;
    }
    
    public static int GetArt(){
        return GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().art;
    }
    public static int GetSoundFX(){
        return GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().soundEffect;
    }
    public static int GetGDesign(){
        return GameObject.Find("Buttons For Work").GetComponent<ButtonsForWork>().gameDesign;
    }
}