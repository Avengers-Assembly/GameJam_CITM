using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float rateTime = 0f;
    bool toRotate = false;

    // Update is called once per frame
    void Update()
    {

        rateTime += Time.deltaTime; 
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            toRotate = true; 
            Debug.Log("Should rotate Left");
            rateTime = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Should rotate Right");
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(-90, Vector3.up), Time.deltaTime);
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }

        if(toRotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(-90, Vector3.up), Time.deltaTime);
        }
    }
}
