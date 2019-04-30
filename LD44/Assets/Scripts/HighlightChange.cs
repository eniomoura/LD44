using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightChange : MonoBehaviour {
    ButtonsForWork bw;
    ColorBlock bedDefault;
    ColorBlock artDefault;
    ColorBlock computerDefault;
    ColorBlock boardDefault;
    ColorBlock musicDefault;

    void Start () {
        bw = GameObject.Find ("Buttons For Work").GetComponent<ButtonsForWork> ();
        bedDefault = GameObject.Find ("bed").GetComponent<Button> ().colors;
        artDefault = GameObject.Find ("art").GetComponent<Button> ().colors;
        computerDefault = GameObject.Find ("computer").GetComponent<Button> ().colors;
        boardDefault = GameObject.Find ("board").GetComponent<Button> ().colors;
        musicDefault = GameObject.Find ("music").GetComponent<Button> ().colors;
    }

    void Update () {
        if (bw.i >= bw.limitOfClicks) {
            ColorBlock bed = GameObject.Find ("bed").GetComponent<Button> ().colors;
            ColorBlock art = GameObject.Find ("art").GetComponent<Button> ().colors;
            ColorBlock computer = GameObject.Find ("computer").GetComponent<Button> ().colors;
            ColorBlock board = GameObject.Find ("board").GetComponent<Button> ().colors;
            ColorBlock music = GameObject.Find ("music").GetComponent<Button> ().colors;

            bed.normalColor = Color.green;
            art.normalColor = Color.red;
            computer.normalColor = Color.red;
            board.normalColor = Color.red;
            music.normalColor = Color.red;
            bed.selectedColor = Color.green;
            art.selectedColor = Color.red;
            computer.selectedColor = Color.red;
            board.selectedColor = Color.red;
            music.selectedColor = Color.red;

            GameObject.Find ("bed").GetComponent<Button> ().colors = bed;
            GameObject.Find ("art").GetComponent<Button> ().colors = art;
            GameObject.Find ("computer").GetComponent<Button> ().colors = computer;
            GameObject.Find ("board").GetComponent<Button> ().colors = board;
            GameObject.Find ("music").GetComponent<Button> ().colors = music;
        } else {
            GameObject.Find ("bed").GetComponent<Button> ().colors = bedDefault;
            GameObject.Find ("art").GetComponent<Button> ().colors = artDefault;
            GameObject.Find ("computer").GetComponent<Button> ().colors = computerDefault;
            GameObject.Find ("board").GetComponent<Button> ().colors = boardDefault;
            GameObject.Find ("music").GetComponent<Button> ().colors = musicDefault;
        }
    }
}