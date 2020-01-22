using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Window3_1 : EventAbstract
{
    public GameObject phone;
    public override void DoAction()
    {
        actor.GetComponent<AudioSource>().Stop();
        phone.GetComponent<AudioSource>().Play();
    }
}
