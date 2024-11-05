using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reject_ONclick : MonoBehaviour
{
    //1
    public GameObject CharacterREJECTED;
    public GameObject cvREJECTED;
    public GameObject diplomaREJECTED;

    //2
    public GameObject Character2REJECTED;
    public GameObject cv2REJECTED;
    public GameObject license2REJECTED;

    private int ClickCounterNO = 0;

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

    if (movingCharacter2.isFinishedMoving == true){
    ClickCounterNO = ClickCounterNO + 1;
    }

    if(ClickCounterNO == 1){
    Character2REJECTED.SetActive(false);
    cv2REJECTED.SetActive(false);
    license2REJECTED.SetActive(false);
    }
    //SecondCharacter.GetComponent<SecondMoveScript>().shouldMove = true;
    }
}
