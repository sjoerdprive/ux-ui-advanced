﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour
{
    public GameObject Panel;

    public void ClosePanel()
    {
        if (Panel.activeSelf)
        {
            Panel.SetActive(false);
        }
    }
}

