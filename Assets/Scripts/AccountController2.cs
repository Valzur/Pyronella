using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AccountController2 : MonoBehaviour
{
    int level;
    float xp=0;
    float weight=0;
    public static int points=5;
    public static int Availablepoints;
    public Text Money;
    public Text LEVEL;
    public Image XP;
    float m=0;
    public static int reducedpoints;

    //Discounts
    public Text Company1;
    public Text Company2;
    public Text Company3;

    public Text Pointstext;
     void Start(){
         XP.fillAmount=xp/(100*(level-1)+100*level);
         Money.text= "Money: " + m.ToString() +"$";
         Company2.text= "0% Discount on Company 2's merchandise";
         Company3.text= "0% Discount on Company 3's merchandise";
         Company1.text= "0% Discount on Company 1's merchandise";
         level=10;
     }
    void Update()
    {
        //Stats
        xp = 1000*weight;
        if (xp >= 100*(level-1)+100*level){
            level+=1;
            XP.fillAmount=xp/(100*(level-1)+100*level);
        }
        LEVEL.text = "Level: " + level.ToString(); 

        //Discounts
        points = Convert.ToInt32(level/10);
        Availablepoints=points-reducedpoints;
        Pointstext.text="Available points: " + Availablepoints.ToString();
    }

}