using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Recorder4_1 : EventAbstract
{

    public override void DoAction()
    {
        // Settejar dialog 
        actor.GetComponent<DialogTrigger>().TriggerDialogue();

        // Posar la corda a true
        GameObject.Find("Rope").SetActive(true);
    }
}
