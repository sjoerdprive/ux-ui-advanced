using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool bo = true;
    public void Activate()
    {
        if (obj != null)
        {
            obj.SetActive(bo);
            if (bo == true)
            {
                bo = false;
            }
            else
            {
                bo = true;
            }
        }
    }
}
