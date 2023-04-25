using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectcoin : MonoBehaviour
{
    public float scoreNum;
    public Text myScore;
    public AudioSource audioPlayer;
    public void Start()
    {
        scoreNum = 0;
        myScore.text = "Gem Core : " + scoreNum + " / " + "15";
    }

    public void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "coin")
        {
            audioPlayer.Play();
            scoreNum += 1;
            col.gameObject.SetActive(false);
            myScore.text = "Gem Core : " + scoreNum + " / " + "15";
        }
        else if(col.gameObject.tag == "NextStage" && scoreNum >= 15)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
    }
}
