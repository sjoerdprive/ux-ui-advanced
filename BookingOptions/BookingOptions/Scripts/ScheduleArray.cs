using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScheduleArray : MonoBehaviour
{
    public GameObject[] schedules;
    public int selectedItm = 1;
    public Text selectedWeek;
    private void Start()
    {
        foreach (GameObject schedules in schedules)
        {
            schedules.SetActive(false);
        }
        schedules[selectedItm].SetActive(true);
        selectedWeek.text = "Week: 3." + (selectedItm + 1);
    }

    public void showNextShedule()
    {
        if(selectedItm <= schedules.Length-2)
        selectedItm++;

        foreach(GameObject schedules in schedules)
        {
            schedules.SetActive(false);
        }
        schedules[selectedItm].SetActive(true);
        selectedWeek.text = "Week: 3." + (selectedItm + 1);
    }

    public void showPrevSchedule()
    {
        if (selectedItm >= 1)
        {
            selectedItm--;
            foreach (GameObject schedules in schedules)
            {
                schedules.SetActive(false);
            }
            schedules[selectedItm].SetActive(true);
            selectedWeek.text = "Week: 3." + (selectedItm + 1);
        }
    }
}
