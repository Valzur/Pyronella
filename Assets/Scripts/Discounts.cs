using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Discounts : MonoBehaviour
{
    public Text Company;
    int x=5;
    public int V;

    public GameObject GameController;

    void Start(){
        Company.name=(0).ToString();
    }
    public void Updatediscount(){
        if (Convert.ToInt32(Company.name)<15 && AccountController2.Availablepoints>0){
        Company.name=(x).ToString();
        Company.text= x.ToString()+ "% Discount on Company "+ V.ToString() + "'s merchandise";
        x=x+5;
        AccountController2.reducedpoints=AccountController2.reducedpoints+1;
        Debug.Log(AccountController2.Availablepoints.ToString());
        }
    }
}
