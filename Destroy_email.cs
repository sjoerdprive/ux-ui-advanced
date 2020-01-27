using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_email : MonoBehaviour
{
    public void Destroy_Click()
    {
        Destroy(transform.parent.gameObject); 
    }
}
