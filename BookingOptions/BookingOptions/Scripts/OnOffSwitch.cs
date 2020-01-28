using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffSwitch : MonoBehaviour
{
    public Sprite onBtn;
    public Sprite offBtn;
    public Image targetImg;

    public void turnMeOnOff()
    {
        if(targetImg.sprite == offBtn)
        {
            targetImg.sprite = onBtn;
        }else if ( targetImg.sprite == onBtn)
        {
            targetImg.sprite = offBtn;
        }
    }
}
