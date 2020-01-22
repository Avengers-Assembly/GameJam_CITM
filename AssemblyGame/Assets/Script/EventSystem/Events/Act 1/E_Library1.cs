using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Library1 : EventAbstract
{
    public GameObject door;
    public override void DoAction()
    {
        actor.GetComponent<DialogTrigger>().TriggerDialogue();
        door.GetComponent<DoorAction>().changesScene = true;
    }
}
