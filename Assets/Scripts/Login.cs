using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField Username;

    public InputField Password;

    public GameObject LoggedinScreen;

    public GameObject SCREEN;
    public float x=0;
    public void LOGIN (){
    if ( Username.text == "Valzur" && Password.text == "Zeletics18" ){
        LoggedinScreen.SetActive(true);
        SCREEN.SetActive(false);
         
    }
    }
}
