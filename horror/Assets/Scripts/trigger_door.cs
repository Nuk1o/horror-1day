using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_door : MonoBehaviour
{
    [SerializeField] private Text text_open_door;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�����");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            text_open_door.text = "����� �������";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�����");
        text_open_door.text = "";
    }
}
