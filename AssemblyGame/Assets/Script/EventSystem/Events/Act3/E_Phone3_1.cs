using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Phone3_1 : EventAbstract
{
    // Start is called before the first frame update
    public override void DoAction()
    {
        // Stop the ringing
        actor.GetComponent<AudioSource>().Stop();

        // Triggejar el dialeg
        actor.GetComponent<DialogTrigger>().TriggerDialogue(3);

        // Crear la nota

    }
}

