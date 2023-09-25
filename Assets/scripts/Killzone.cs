using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject GameOverImage;
    public static GameObject GameOverStatic;
    public static GameObject GameOverImageStatic;
    public static bool GameOver;
    void Start()
    {
        Killzone.GameOverStatic = GameOverText;
        Killzone.GameOverStatic.gameObject.SetActive(false);
        Killzone.GameOverImageStatic = GameOverImage;
        Killzone.GameOverImageStatic.gameObject.SetActive(false);
        GameOver = false;
    }
    private void Update()
    {
        if (GameOver == true)
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        Killzone.GameOverStatic.gameObject.SetActive(true);
        Killzone.GameOverImageStatic.gameObject.SetActive(true);
    }
}
