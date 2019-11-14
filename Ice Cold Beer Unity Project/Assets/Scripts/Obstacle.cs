using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject GameOverText;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Oooooo you touched my tralala");
        if (collision.tag == "Player")
        {
            GameOverText.SetActive(true);
            //cue sound effect here
            audioSource.Play();
            Debug.Log("You touched the obstacle.");
        }
    }
}
