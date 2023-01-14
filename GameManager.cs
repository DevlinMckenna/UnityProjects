using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Slider mySlide;
    public Text ContestNumber;
    int cn;
    float slideNum;
    public Text PositivePlayerType;
    public Text NegativePlayerType;
   
    void Start()
    {
        ContestNumber.text = "welcome";
        cn= 0;
        
       mySlide.value= (float)cn;
    

    }


    void Update()
    {
        if (Input.GetKey("a"))
        {
            if (Input.GetKey("l")){
            cn++;
            ContestNumber.text = cn.ToString();
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Fire";
            NegativePlayerType.text = "Plant";
            
            }
            if (Input.GetKey("k")){
            cn--;
            ContestNumber.text = cn.ToString() ;
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Fire";
            NegativePlayerType.text = "Water";
            
            
            }
            if (Input.GetKey("j")){ 
                NegativePlayerType.text="Fire";
                PositivePlayerType.text = "Fire";}
        }

        if (Input.GetKey("s"))
        {
            if (Input.GetKey("j")){
            cn++;
            ContestNumber.text = cn.ToString() ;
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Water";
            NegativePlayerType.text = "Fire";
            
            }
            if (Input.GetKey("l")){
            cn--;
            ContestNumber.text = cn.ToString() ;
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Water";
            NegativePlayerType.text = "Plant";
            ContestNumber.text = cn.ToString() ;
            }
            if (Input.GetKey("k")){
                PositivePlayerType.text="Water";
                 NegativePlayerType.text = "Water";}
        }

        if (Input.GetKey("d"))
        {
            if (Input.GetKey("k")){
            cn++;
            ContestNumber.text = cn.ToString() ;
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Plant";
            NegativePlayerType.text = "Water";
            
            }
            if (Input.GetKey("j")){
            cn--;
            ContestNumber.text = cn.ToString() ;
            mySlide.value= (float)cn;
            PositivePlayerType.text = "Plant";
            NegativePlayerType.text = "Fire";
            ContestNumber.text = cn.ToString() ;
            }
            if (Input.GetKey("l")){ 
                PositivePlayerType.text="Plant";
                NegativePlayerType.text = "Plant";}
        }

        

    }




    
}
