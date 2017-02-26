using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{
    CharacterController CharacterCollider;
    public float walkSpeed = 0.0666f;
    public float runSpeed = 0.1333f;
    public float crouchSpeed = 0.05f;
    float dist;
    // Use this for initialization
    void Start()
    {

        //Prevent the player from falling  
        this.GetComponent<Rigidbody>().freezeRotation = true;

        CharacterCollider = gameObject.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    //check the state of the character (up/down, running/walking)
    bool isCrouching = false;
    bool isRunning = false;

    void Movement()
    {
        //determine the speed in depending on the movement (running, walking, crouching)
        float speed = walkSpeed;
        if (isRunning)
            speed = runSpeed;
        else if (isCrouching)
            speed = crouchSpeed;

        //Permise movements of the player with the different buttons
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
            this.transform.Translate(Vector3.left * speed);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            this.transform.Translate(Vector3.right * speed);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
            this.transform.Translate(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            this.transform.Translate(Vector3.back * speed);
        if (Input.GetKey(KeyCode.Space))
            this.transform.Translate(Vector3.up * speed);

        if (Input.GetKey(KeyCode.LeftShift) && !isCrouching)
            isRunning = true;
        else
            isRunning = false;

        if (Input.GetKeyDown(KeyCode.LeftControl) && !isCrouching && !isRunning)
        {
            isCrouching = true;
            CharacterCollider.height = 1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) && isCrouching)
        {
            isCrouching = false;
            CharacterCollider.height = 1.8f;
        }
    }
}
