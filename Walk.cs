using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{

    public float walkSpeed;
    public float runSpeed;
    public float crouchSpeed;
    float dist;
    // Use this for initialization
    void Start()
    {
        walkSpeed = 0.1f;
        runSpeed = 0.2f;
        crouchSpeed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    //Permise movements of the player with the different buttons
    private bool isRunning = false;
    void Movement()
    {
        float speed;
        if (isRunning)
            speed = runSpeed;
        else
            speed = walkSpeed;
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * speed);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.back * speed);
        if (Input.GetKey(KeyCode.Space))
            this.transform.Translate(Vector3.up * speed);

        if (Input.GetKey(KeyCode.LeftShift))
            isRunning = true;
        else
            isRunning = false;
    }
}