using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Phone1 : EventAbstract
{
    // Start is called before the first frame update
    public override void DoAction()
    {
        // Stop the ringing
        Debug.Log("Doing Event Phone 1 Actiion");
        actor.GetComponent<AudioSource>().Stop();

        // Triggejar el dialeg
        actor.GetComponent<DialogTrigger>().TriggerDialogue();

        // Crear la nota
         
    }
}
