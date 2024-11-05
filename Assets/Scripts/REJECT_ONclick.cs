using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reject_ONclick : MonoBehaviour
{
    public GameObject CharacterREJECTED;
    public GameObject cvREJECTED;
    public GameObject diplomaREJECTED;

    public SecondMoveScript characterSecondMOVE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click(){
    CharacterREJECTED.SetActive(false); 
    cvREJECTED.SetActive(false);
    diplomaREJECTED.SetActive(false);
    characterSecondMOVE.StartMovement();
    }
}
