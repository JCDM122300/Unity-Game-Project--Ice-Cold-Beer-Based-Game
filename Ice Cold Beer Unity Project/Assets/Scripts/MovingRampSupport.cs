using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    //created the variable for movement speed
    //variables are useful for replacing numbers with words which essentially makes your code easier to read.
    private float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Smoke Weed Everyday (This is a log test)");
        //transform.Translate(5,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //if the player presses the up arrow, the square will then move up the specified distance every frame until the button is released
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -1 * moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1 * moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        //Controls for WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed, 0, 0);
        }










        //Debug.Log("UPDATE METHOD");
        //transform.Translate(0.1f, 0, 0);

    }
}
