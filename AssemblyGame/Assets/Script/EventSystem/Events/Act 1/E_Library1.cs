using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Library1 : EventAbstract
{
    public GameObject door;
    public override void DoAction()
    {
        door.GetComponent<DoorAction>().changesScene = true;
    }
}
