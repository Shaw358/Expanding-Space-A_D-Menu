using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelector : MonoBehaviour
{

    public void Start_Game()
    {
        SceneManager.LoadScene("Menu");
    }

}
