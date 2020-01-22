using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPhoneAction : MonoBehaviour
{
    // Start is called before the first frame update
    public void Action()
    {
        int value;
        // attempt to parse the value using the TryParse functionality of the integer type
        int.TryParse(name, out value);
        transform.parent.parent.GetComponent<PhoneAction>().SetNumber(value);
    }
}
