using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenssage : MonoBehaviour
{
    public GameObject VictoryText;
    
    public static GameObject VictoryStatic;
    public static bool Victory;
    void Start()
    {
        Victory = false;
        VictoryMenssage.VictoryStatic = VictoryText;
        VictoryMenssage.VictoryStatic.gameObject.SetActive(false);
       
    }
    private void Update()
    {
        if (Victory == true)
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
    }
    public static void show()
    {
        VictoryMenssage.VictoryStatic.gameObject.SetActive(true);
        
    }
}
