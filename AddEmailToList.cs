using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEmailToList : MonoBehaviour
{
    public GameObject itemTemplate;

    public GameObject TextTemplate;

    public GameObject Content;

    public void AddEmail_Click()
    {
        var input = Instantiate(TextTemplate);

        var text = input.GetComponentInChildren<Text>().text;

        var copy = Instantiate(itemTemplate);
        copy.transform.parent = Content.transform;

        copy.GetComponentInChildren<Text>().text = text.ToString();
        

        

    }
}
