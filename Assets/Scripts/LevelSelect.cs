using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelect : MonoBehaviour
{
    public List<GameObject> fases;

    private GameObject selected;

    void Start()
    {
        //Pega todos os filhos dos objetos com os botões de fases e adiciona a lista de fases
        foreach (Transform child in transform)
        {
            fases.Add(child.gameObject);
        }
        
    }

    public void LevelChange()
    {
        selected = EventSystem.current.currentSelectedGameObject;

        SceneManager.LoadScene(fases.IndexOf(selected.gameObject) + 2);
    }


}
