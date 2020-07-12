using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;
    public float movespeed = 600f; 
    float movement = 0f;
    public double score;
    public GameObject levelCompleteUI;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate(){
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movespeed);
        score = score + 1 * Time.fixedDeltaTime;
        scoreText.text = score.ToString("0");
        if(score >= 50){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(score >= 100){
            levelCompleteUI.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}
