using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACCEPT_ONclick : MonoBehaviour
{
    public GameObject failText1;
    public GameObject failText2;
    //1
    public GameObject CharacterACCEPTED;
    public GameObject cvACCEPTED;
    public GameObject diplomaACCEPED;

    //2
    public GameObject Character2ACCEPTED;
    public GameObject cv2ACCEPTED;
    public GameObject license2ACCEPTED;

    private int ClickCounterYES = 0;

    SecondMoveScript MovingCharacter2;


    // Start is called before the first frame update
    void Start()
    {
        MovingCharacter2 = GameObject.Find("Character2Sprite").GetComponent<SecondMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click(){
    CharacterACCEPTED.GetComponent<ForwardMovingCharacter>().transform.position = new Vector3(14,3.22f,0);
    cvACCEPTED.SetActive(false);
    diplomaACCEPED.SetActive(false);
    MovingCharacter2.StartMoving();
    failText1.SetActive(true);

    if (MovingCharacter2.isFinishedMoving == true){
    ClickCounterYES = ClickCounterYES + 1;
    }

    if(ClickCounterYES == 1){
    Character2ACCEPTED.GetComponent<SecondMoveScript>().transform.position = new Vector3(12,3.22f,0);
    cv2ACCEPTED.SetActive(false);
    license2ACCEPTED.SetActive(false);
    failText2.SetActive(true);
    }
}
}
