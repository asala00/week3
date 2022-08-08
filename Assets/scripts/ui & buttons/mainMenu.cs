using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;

    public void playG()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void QuitG()
    {
        Application.Quit();
    }
}
