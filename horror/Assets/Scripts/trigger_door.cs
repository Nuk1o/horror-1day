using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_door : MonoBehaviour
{
    [SerializeField] private Text text_open_door;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Зашёл");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            text_open_door.text = "Дверь закрыта";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Вышел");
        text_open_door.text = "";
    }
}
