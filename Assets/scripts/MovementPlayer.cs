using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;
    bool GameOver;
    int Score;
    [SerializeField] Text ScoreText;
    void Start()
    {
        Score = 0; ;
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Kill zone"))
        {
            Time.timeScale = 0;
            Killzone.show();
            Killzone.GameOver = true;
            
        }       
        if (collision.gameObject.CompareTag("Win"))
        {
            VictoryMenssage.show();
            Time.timeScale = 0;
            VictoryMenssage.Victory = true;
        }
        if (collision.gameObject.CompareTag("Limits"))
        {
            Limitszone.show();
            Time.timeScale = 0;
            Limitszone.GameOver = true;   
        }
        if (collision.gameObject.CompareTag("Score"))
        {
            Score++;
            ScoreText.text = Score + " / 7";
            Destroy(collision.gameObject);
        }
    }
}
   
