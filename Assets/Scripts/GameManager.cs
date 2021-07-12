using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionMenu;

    void Awake() 
    {
        //pauseMenu = GameObject.Find("Menu Pause");

        //optionMenu = GameObject.Find("Menu Options");
    }

    public void Pause()
    {
        Time.timeScale = 0;

        pauseMenu.SetActive(true);
    }
    public void Despause()
    {
        pauseMenu.SetActive(false);

        Time.timeScale = 1;

        optionMenu.SetActive(false);

    }

}


