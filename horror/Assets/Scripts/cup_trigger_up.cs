using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace Questc
{
    public class cup_trigger_up : MonoBehaviour
    {
        [SerializeField] GameObject cupUp;
        [SerializeField] Text cup_text_up;
        [SerializeField] Text help_text;
        [SerializeField] public int cup;
        private void Start()
        {
            cup = 0;
            serbinary();
        }
        private void OnTriggerEnter(Collider other)
        {
            help_text.text = "ֽאזלטעו E";
        }
        private void OnTriggerStay(Collider other)
        {
            if (Input.GetKey(KeyCode.E))
            {
                cupUp.SetActive(false);                              
                derbinary();
                Debug.Log(cup + " " + 1);
                cup = Int32.Parse(cup_text_up.text);
                cup = cup + 1;
                Debug.Log(cup + " " + 2);
                serbinary();
                derbinary();
                Debug.Log(cup + " " + 3);
                help_text.text = "";
            }
        }

        private void OnTriggerExit(Collider other)
        {
            help_text.text = "";            
        }

        void serbinary()
        {
            Cups _cups = new Cups(cup);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("cups", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _cups);
            }
        }

        void derbinary()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("cups", FileMode.OpenOrCreate))
            {
                Cups _cups = (Cups)formatter.Deserialize(fs);
                cup_text_up.text = _cups.Kol_cup.ToString();
            }
        }
    }
}

[Serializable]

class Cups
{
    public int Kol_cup { get; set; }
    public Cups(int Kol)
    {
        Kol_cup = Kol;
    }
}