﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
        Time.timeScale = DataMutator.Instance.speed;
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        DataMutator.Instance.speed = speed;
        //Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void GamePause()
    {
        speed = DataMutator.Instance.speed;
        pauseMenuUI.SetActive(true);
        DataMutator.Instance.speed = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
