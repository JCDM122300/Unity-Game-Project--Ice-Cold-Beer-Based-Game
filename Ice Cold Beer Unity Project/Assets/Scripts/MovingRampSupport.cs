using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{    public float moveSpeed = 1f;
    public string inputAxis;
    private Rigidbody2D rigidBody;  //when making the variable, name it the same as the class but lowercase
    private float verticalInput;





    //private SpriteRenderer spriteRenderer;

    //everything found in the components in unity can be accessed here in VS


    //created the variable for movement speed
    //variables are useful for replacing numbers with words which essentially makes your code easier to read.
 
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.green;
        } */

        //if you use Input.GetKey, you would not be able to remap the controls so the player can change to their liking.

        rigidBody = GetComponent<Rigidbody2D>(); //this finds the exact component that we need to reference  //also everything here and in unity have a connection
        
        
        
    }


    //used fixed update for physics code, because we need to be careful about how often we call expensive, hardware intensive, physics stuff
    private void FixedUpdate()
    {
      if (!GameOver.IsGameOver)
        {
             rigidBody.velocity = new Vector2(0, verticalInput * moveSpeed); //this puts a cap on how fast the player moves (?)
        } 

    }

    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis); //stored verticalInput with how far the player tilts the control stick vertically
        //using this input from the project settings allows for easier configuration for the controls. On an even better side, the default controls are already mapped out in Unity
        //It also allows us to deal with analog control with sticks as well. (tells us how far it is being tilted)
    }


}
