using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Recorder2 : EventAbstract
{
    public override void DoAction()
    {
        actor.GetComponent<DialogTrigger>().TriggerDialogue(2);
    }
}
