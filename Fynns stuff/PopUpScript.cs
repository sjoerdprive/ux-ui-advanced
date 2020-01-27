using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    public GameObject popUp;

    public void showPopUP()
    {
        if (popUp.activeSelf == false)
        {
            popUp.SetActive(true);
        }
        else if(popUp.activeSelf == true)
        {
            popUp.SetActive(false);
        }
    }
}
