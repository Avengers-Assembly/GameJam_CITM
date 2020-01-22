using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public List<EventAbstract> eventQueue;

    public bool CheckNextEvent(GameObject asking)
    {
        if (eventQueue.Count == 0)
            return false; 

        Debug.Log("Checking if " + asking.name + "is the next event actor but is" + eventQueue.First().actor.name);
        return eventQueue.First().actor == asking;
    }
    
    public void ExecuteNextEvent()
    {
        Debug.Log("Exectuing Event Action");
        eventQueue.First().DoAction();
        eventQueue.RemoveAt(0);
    }
}
