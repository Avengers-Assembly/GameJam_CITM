using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialogue[] dialogue;
    public void TriggerDialogue(int index)
    {
         FindObjectOfType<DialogueManager>().StartDialogue(dialogue[index]);
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue[0]);
    }
    public void SwapDefault(int index)
    {
        if (dialogue[index] == null)
            return;
        Dialogue aux = dialogue[0];
        dialogue[0] = dialogue[index];
        dialogue[index] = aux;
    }
}
