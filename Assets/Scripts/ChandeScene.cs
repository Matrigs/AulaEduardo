using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChandeScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Change Scene");
            //SceneManager.LoadScene("Level 2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }




}
