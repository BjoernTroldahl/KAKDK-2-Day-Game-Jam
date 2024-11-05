using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMoveScript : MonoBehaviour
{
    // Speed of movement along the x-axis
    public float speed = 2.0f;
    // The target x-coordinate at which the sprite should stop
    private float TWOstopPositionX;
    public GameObject CV2;
    public GameObject LICENSE2;
    public bool shouldMove = false;
    public bool isFinishedMoving = false;
    //public GameObject RejectButton;
    public GameObject failTEXT1;
    public GameObject successTEXT1;
    void Start()
    {
    // Calculate 1/3 of the game window width in world units
    TWOstopPositionX = Camera.main.ViewportToWorldPoint(new Vector3(1.0f / 2.0f, 0, 0)).x;
    }

    void Update()
    {
        if (shouldMove && transform.position.x < TWOstopPositionX) //shouldMove &&
        {
            // Move the sprite along the x-axis
            transform.position += Vector3.right * speed * Time.deltaTime;
            isFinishedMoving = false;
        }
        else if (transform.position.x >= TWOstopPositionX){
        CV2.SetActive(true);
        LICENSE2.SetActive(true);
        isFinishedMoving = true;
        failTEXT1.SetActive(false);
        successTEXT1.SetActive(false);
        //shouldMove = false; // Stop further movement
        }
    }

    public void StartMoving()
    {
        shouldMove = true;  // Allow movement
    }

    // public void StartMovement()
    //{
        //shouldMove = true;
    //}
}
