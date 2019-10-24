using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Detects when the ball touches the goal and then win the level
/// </summary>
public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Oooooo you touched my tralala");
        if (collision.tag == "Player")
        {
            Debug.Log("Bitches stole my god damned candy for the last time");
        } 
    }
}
