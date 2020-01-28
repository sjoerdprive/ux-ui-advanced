using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueChange : MonoBehaviour
{
    public Text targetText;
    public Text newText;

    public void changeValue()
    {
        targetText.text = newText.text;
    }
}
