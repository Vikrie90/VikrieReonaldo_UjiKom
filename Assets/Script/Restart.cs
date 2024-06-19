 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;


public class Restart : MonoBehaviour
{
public GameObject PauseMenu;
void Start()
    {
        HideMenu();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PauseMenu.activeSelf)
            {
                HideMenu(); 
            }
            else
            {
                ShowMenu(); 
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
   {
    SceneManager.LoadSceneAsync(0);
   }

    void ShowMenu()
    {
        PauseMenu.SetActive(true); 
    }

    void HideMenu()
    {
        PauseMenu.SetActive(false); 
    }

}
