using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Rope4_1 : EventAbstract
{
    public override void DoAction()
    {
        actor.GetComponent<DialogTrigger>().TriggerDialogue();
    }
}
