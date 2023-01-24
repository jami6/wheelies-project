using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // can have only one parameter
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

}  
