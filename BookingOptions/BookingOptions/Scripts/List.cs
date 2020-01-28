using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public InputField inpt;
    public List<string> receivers;
    public string newReceiver;
    public string lastReceiver;
    public GameObject listObj;

    [SerializeField] Transform menuPanel;
    [SerializeField] GameObject listItmPrefab;
    [SerializeField] Text myText;

    private void Update()
    {
        newReceiver = inpt.text;


    }

    public void addReceiver()
    {
        if ( newReceiver != "") {
            receivers.Add(newReceiver);
            lastReceiver = newReceiver;
            inpt.text = "";
            Debug.Log(receivers);
            GameObject itm = Instantiate(listItmPrefab);
            Debug.Log(lastReceiver);
            itm.GetComponentInChildren<Text>().text = lastReceiver;
            itm.transform.SetParent(menuPanel, false);
            
        }
    }
}
