using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Final_2 : EventAbstract
{
    public GameObject phone; 
    public override void DoAction()
    {
        if (GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed)
        {
            phone.GetComponent<AudioSource>().Play();
        }

        else
        {
            // Do nothing
        }
    }
}
