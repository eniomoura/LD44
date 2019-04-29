using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reviewers : MonoBehaviour {
    public Text[] children;

    public float art;
    public float code;
    public float gd;
    public float sound;
    public int reducingFactor;
        
    void Start () {
        children = GetComponentsInChildren<Text> ();
        int reviewGrade1 = 0, reviewGrade2 = 0, reviewGrade3 = 0;
        art = ButtonsForWork.GetArt () / reducingFactor;
        code = ButtonsForWork.GetProgramming () / reducingFactor;
        gd = ButtonsForWork.GetGDesign () / reducingFactor;
        sound = ButtonsForWork.GetSoundFX () / reducingFactor;

        foreach (Text chText in children) {
            switch (chText.gameObject.name) {
                case "Memetric":
                    reviewGrade1 = (int) (art * 2 + code * 1 + gd * 2 + sound * 1 + 40) / 10;
                    chText.text += reviewGrade1 + "/10";
                    break;
                case "Rock, Paper, Please":
                    reviewGrade2 = (int) (art * 1 + code * 3 + gd * 2 + sound * 2 + 20) / 10;
                    chText.text += reviewGrade2 + "/10";
                    break;
                case "High GN":
                    reviewGrade3 = (int) (art * 4 + code * 3 + gd * 1 + sound * 2) / 10;
                    chText.text += reviewGrade3 + "/10";
                    break;
                case "FinalGrade":
                    chText.text += ((reviewGrade1 + reviewGrade2 + reviewGrade3) / 3).ToString () + "/10";
                    break;
                case "Life expectancy":
                    chText.text = "You lost "+DecisaoVida.vida+" years of life, from the decisions you took this weekend.";
                    break;
            }
        }
    }
}