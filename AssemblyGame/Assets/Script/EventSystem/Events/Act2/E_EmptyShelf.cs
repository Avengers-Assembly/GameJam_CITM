using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_EmptyShelf : EventAbstract
{
    public GameObject door; 
    public override void DoAction()
    {
        actor.GetComponent<DialogTrigger>().TriggerDialogue(1);
        
        // Open door
        door.GetComponent<DoorAction>().changesScene = true;
    }
}

