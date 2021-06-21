using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void StageSelect()
    {
        //SceneManager.LoadScene("StageSelect");
        Debug.Log("Seleção de Fases");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }




}
