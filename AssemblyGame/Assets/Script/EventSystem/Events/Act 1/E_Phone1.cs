using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Phone1 : EventAbstract
{
    // Start is called before the first frame update
    public override void DoAction()
    {
        Debug.Log("Doing Event Phone 1 Actiion");
        actor.GetComponent<AudioSource>().Stop();
    }
}
