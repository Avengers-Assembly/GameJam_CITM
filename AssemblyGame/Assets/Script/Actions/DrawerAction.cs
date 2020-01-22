using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAction : AbstractAction
{
    public bool locked = true;

    public override void DoMyOwnAction()
    {
        if (locked == true)
        {
            // Trigguer Locked Dialogue    
        }

        else
        {
            // Trigger Empty Dialogue

            // Unlock Door
        }
    }
}
