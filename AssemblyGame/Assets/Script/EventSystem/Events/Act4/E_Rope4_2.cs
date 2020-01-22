using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Rope4_2 : EventAbstract
{
    public override void DoAction()
    {
        // Cut rope

        // "Kill" him
        GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed = true; 
    }
}

