using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSound : MonoBehaviour
{
    public AudioSource audioPlayer;

    public void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            audioPlayer.Play();
        }
    }
}
