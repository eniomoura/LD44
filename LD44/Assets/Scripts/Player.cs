using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int fome = 0;
    //public int sono = 10;
    public int sanidade = 10;

    public int saude;
    //public int ojogo;
    public Text life;
    public Text mind;
    public Text stomach;

    
    public int numsprite;

    public Sprite [] states;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       fome = int.Parse(stomach.text);
       sanidade = int.Parse(mind.text);
       saude = int.Parse(life.text);
        if(fome <= 3 && sanidade > 3){
            gameObject.GetComponent<Image>().sprite = states[1];
        }
        else if(fome > 3 && sanidade <= 3 && saude >3){
            gameObject.GetComponent<Image>().sprite = states[2];
        }
        else if(fome <= 3 && sanidade <= 3 && saude >3){
            gameObject.GetComponent<Image>().sprite = states[3];
        }
        else if(fome > 3 && sanidade > 3 && saude <=3){
            gameObject.GetComponent<Image>().sprite = states[4];
        }
        else if(fome <= 3 && sanidade > 3 && saude <=3){
            gameObject.GetComponent<Image>().sprite = states[5];
        }
        else if(fome > 3 && sanidade <= 3 && saude <=3){
            gameObject.GetComponent<Image>().sprite = states[6];
        }
        else if(fome <= 3 && sanidade <= 3 && saude <=3){
            gameObject.GetComponent<Image>().sprite = states[7];
        }
        else{
            gameObject.GetComponent<Image>().sprite = states[0];
        }
    }
}
