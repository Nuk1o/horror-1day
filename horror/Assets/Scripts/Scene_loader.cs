using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    [SerializeField] private string name;
    public void nukio()
    {
        SceneManager.LoadScene(name);
    }
}
