using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Despause()
    {
        Time.timeScale = 1;
    }
}   
