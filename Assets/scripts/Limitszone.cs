using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Limitszone : MonoBehaviour
{
    public GameObject FallGameOverText;
    public GameObject FallGameOverImage;
    public static GameObject FallGameOverStatic;
    public static GameObject FallGameOverImageStatic;
    public static bool GameOver;
    void Start()
    {
        Limitszone.FallGameOverStatic = FallGameOverText;
        Limitszone.FallGameOverStatic.gameObject.SetActive(false);
        Limitszone.FallGameOverImageStatic = FallGameOverImage;
        Limitszone.FallGameOverImageStatic.gameObject.SetActive(false);
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
        Limitszone.FallGameOverStatic.gameObject.SetActive(true);
        Limitszone.FallGameOverImageStatic.gameObject.SetActive(true);

    }
}
