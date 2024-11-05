using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reject_ONclick : MonoBehaviour
{
    public GameObject CharacterREJECTED;
    public GameObject cvREJECTED;
    public GameObject diplomaREJECTED;

    SecondMoveScript movingCharacter2;

    //public GameObject SecondCharacter;
    // Start is called before the first frame update
    void Start()
    {
        movingCharacter2 = GameObject.Find("Character2Sprite").GetComponent<SecondMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click(){
    CharacterREJECTED.SetActive(false); 
    cvREJECTED.SetActive(false);
    diplomaREJECTED.SetActive(false);
    movingCharacter2.StartMoving();
    //SecondCharacter.GetComponent<SecondMoveScript>().shouldMove = true;
    }
}
