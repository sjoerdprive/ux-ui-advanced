using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeList : MonoBehaviour
{
    public Text inputField;
    public GameObject list;

    public GameObject newItem;
    public Text inputText;

    public float distance = 15f;

    public void addInputToList()
    {
        inputText = inputField;



        Instantiate(newItem, inputField.GetComponent<Transform>());

        newItem.GetComponent<Text>().text = inputField.text;

        inputField.GetComponent<Text>().text = "";
    }
}
