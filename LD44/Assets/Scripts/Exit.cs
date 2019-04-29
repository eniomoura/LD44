using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public Transform destination;
     public Transform destination2;
    public Color alphaing;
    public int speed ;
    
    public int stage =0;
    void Start()
    {
        alphaing = menu.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape) && stage == 0){
            stage =2;
        }
        fade();
    }
   void fade(){
       if(stage == 1 && alphaing.a !=0 ){
            
            alphaing = menu.GetComponent<Image>().color;
            alphaing.a -= speed * Time.deltaTime;
            menu.GetComponent<Image>().color = alphaing;
        }
        else if(stage == 1 && alphaing.a ==0 ){
          
            alphaing = menu.GetComponent<Image>().color;
            alphaing.a -= speed * Time.deltaTime;
            menu.GetComponent<Image>().color = alphaing;
        }
        else if(stage == 2 && alphaing.a !=1){
            
            alphaing = menu.GetComponent<Image>().color;
            alphaing.a += speed * Time.deltaTime;
            menu.GetComponent<Image>().color = alphaing;
        }
   }
}
