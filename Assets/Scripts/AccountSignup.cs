using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountSignup : MonoBehaviour
{
    public InputField UsernameEntered;
    public InputField PasswordEntered;
    public Text usernamesave;
    public Text passwordsave;

    public InputField LOGINUSERNAME;

    public InputField LOGINPASSWORD;

    public GameObject SUCCESSFULL;

    public GameObject FAILED;
    public GameObject SIGNUPSUCCESSFULL;
    public GameObject SIGNUPFAILED;
    public GameObject LOGINPANEL;
    public GameObject LOGINSCREEN;
    public InputField FULLNAME;
    public Text SAVEDNAME;
    public void account(){
        if (UsernameEntered.text == usernamesave.text){
            SIGNUPFAILED.SetActive(true);
        }else{
        usernamesave.text = UsernameEntered.text;
        passwordsave.text = PasswordEntered.text;
        SAVEDNAME.text = FULLNAME.text;
        SIGNUPSUCCESSFULL.SetActive(true);
        }
    }

    public void LOGIN(){
        if (usernamesave.text == LOGINUSERNAME.text && passwordsave.text == LOGINPASSWORD.text){
            SUCCESSFULL.SetActive(true);
            LOGINPANEL.SetActive(false);
        }else{
            FAILED.SetActive(true);
            LOGINSCREEN.SetActive(true);
            LOGINPANEL.SetActive(false);
        }
    }
    public void NAMECHANGE(){

    }
   }
