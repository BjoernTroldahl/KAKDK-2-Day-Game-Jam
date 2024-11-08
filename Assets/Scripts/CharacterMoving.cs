using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ForwardMovingCharacter : MonoBehaviour
{ 
    // Speed of movement along the x-axis
    public float speed = 2.0f;
    // The target x-coordinate at which the sprite should stop
    private float stopPositionX;
    public GameObject CV;
    public GameObject DIPLOMA;
    //public GameObject RejectButton;
    void Start()
    {
    // Calculate 1/3 of the game window width in world units
    stopPositionX = Camera.main.ViewportToWorldPoint(new Vector3(1.0f / 2.0f, 0, 0)).x;
    }

    void Update()
    {
        if (transform.position.x < stopPositionX)
        {
            // Move the sprite along the x-axis
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else{
        CV.SetActive(true);
        DIPLOMA.SetActive(true);
        }
    }
}
