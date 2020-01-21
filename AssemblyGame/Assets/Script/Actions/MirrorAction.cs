using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorAction : AbstractAction
{
    public override void OnAction()
    {
        GetComponent<DialogTrigger>().TriggerDialogue();
    }
}
