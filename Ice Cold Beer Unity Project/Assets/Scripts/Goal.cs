using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Detects when the ball touches the goal and then win the level
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject WinText;
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
            WinText.SetActive(true);
            //cue sound effect here
            audioSource.Play();
            Debug.Log("Yaaaaaaaay, you touched the goal");
            GameOver.IsGameOver = true;
        } 
    }
}
