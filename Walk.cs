using UnityEngine;
using System.Collections;
using System.Timers;

public class Walk : MonoBehaviour
{
    public float speed;
	// Use this for initialization
	void Start ()
    {
        speed = 0.1f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
	}

    //Permise movements of the player with the different buttons
    void Movement()
    {
        Timer timer = new Timer(1000);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * speed);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.back * speed);
        /*if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.up * speed);
            timer.Enabled = true;
            timer.Start();
            this.transform.Translate(Vector3.down * speed);
        }*/

    }
}
