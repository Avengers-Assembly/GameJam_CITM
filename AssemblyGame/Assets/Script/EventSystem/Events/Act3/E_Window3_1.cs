using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Window3_1 : EventAbstract
{
    public GameObject phone;
    public override void DoAction()
    {
        phone.GetComponent<AudioSource>().Play();
    }
}
