using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Questc;
using System;

public class Quest_cup : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject door_trigger;
    [SerializeField] Text _text;
    [SerializeField] public int kol_c;
    Vector3 door_open = new Vector3(0, 45, 0);
    void Update()
    {
        kol_c = Int32.Parse(_text.text);
        if (kol_c == 3)
        {
            door.transform.rotation = Quaternion.Euler(door_open);
            door_trigger.SetActive(false);
        }
    }
}


