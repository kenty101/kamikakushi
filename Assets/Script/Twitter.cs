using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Twitter : MonoBehaviour
{
    public void OnClickTwitterButton()
    {

        var userName = "kenty101xxx";
        Application.OpenURL("https://twitter.com/" + userName);
  
    }
   
}
