using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float rateTime = 0f;
    float currentAngle = 0f;
    float angleToRotate = 0f; 
    bool toRotate = false;

    // Update is called once per frame
    void Update()
    {
        rateTime += Time.deltaTime;

        currentAngle = transform.rotation.eulerAngles.y;

        if(Input.GetKeyDown(KeyCode.LeftArrow) && !toRotate)
        {
            toRotate = true;
            angleToRotate = currentAngle - 90f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !toRotate)
        {
            toRotate = true;
            angleToRotate = currentAngle + 90f;
        }

        if(toRotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angleToRotate, Vector3.up), Time.deltaTime);
            Debug.Log(currentAngle);
            if (currentAngle == angleToRotate)
                toRotate = false;
        }
    }
}
