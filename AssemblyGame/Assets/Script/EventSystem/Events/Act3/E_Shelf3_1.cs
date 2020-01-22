using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Shelf3_1 : EventAbstract
{
    public GameObject window;
    public override void DoAction()
    {
        AudioSource[] audious = actor.GetComponents<AudioSource>();
        actor.GetComponent<DialogTrigger>().TriggerDialogue(1);

        // Active window sound
        window.GetComponent<AudioSource>().Play();
    }
}
