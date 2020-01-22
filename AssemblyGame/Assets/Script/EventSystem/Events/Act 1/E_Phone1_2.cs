using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Phone1_2 : EventAbstract
{
    public GameObject door;
    public override void DoAction()
    {
        actor.GetComponent<DialogTrigger>().TriggerDialogue(2);
        door.GetComponent<DoorAction>().changesScene = true;
    }
}
