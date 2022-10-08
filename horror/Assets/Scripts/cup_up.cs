using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cup_up : MonoBehaviour
{
    [SerializeField] GameObject cupUp;
    [SerializeField] Text cup_text_up;
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            cupUp.SetActive(false);
            Quest_cup _quest = new Quest_cup();
            //cup += 1;
            //cup_text_up.text = cup.ToString();
        }
    }
}
