using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour
{
    public GameObject levelComp;
    public void ResetGame(){
        levelComp.SetActive(false);
        SceneManager.LoadScene("Level01");
    }

    public void quitGameEnd(){
        Application.Quit();
    }
}
