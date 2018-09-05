using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject deathPanel;
    private bool pauseGame = false;

    private void Start()
    {
        deathPanel.SetActive(false);
    }

    public void GameOver()
    {
        //open deathpanel
        deathPanel.SetActive(true);
        //stop time.....
        ToggleTime();
    }

    private void ToggleTime()
    {
        pauseGame = !pauseGame;

        if (pauseGame)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }


    public void Retry()
    {
        ToggleTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


//end o class
}
