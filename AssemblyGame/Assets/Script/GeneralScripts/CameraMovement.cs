using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float timeToRotate = 10f;
    float rateTime = 1f;
    float currentRotationTime = 0f;
    float currentAngle = 0f;
    float angleToRotate = 0f; 
    bool toRotate = false;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        currentAngle = transform.rotation.eulerAngles.y;

        if(angleToRotate < 0)
        {
            angleToRotate = 270;
        }
        else if (angleToRotate >= 360)
        {
            angleToRotate = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !toRotate)
        {
            toRotate = true;
            angleToRotate = currentAngle - 90f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !toRotate)
        {
            toRotate = true;
            angleToRotate = currentAngle + 90f;
        }

        if (toRotate)
        {
            InterpolateRotation();
        }

    }

    private void InterpolateRotation()
    {
        if (Mathf.Abs(angleToRotate - currentAngle) >= 0.01f)
        {
            currentRotationTime += Time.deltaTime * (1 / timeToRotate);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angleToRotate, Vector3.up), currentRotationTime);

            Debug.Log("Current angle: " + currentAngle);
            Debug.Log("Angle to rotate: " + angleToRotate);
        }
        else
        {
            transform.rotation = Quaternion.AngleAxis(angleToRotate, Vector3.up);
            currentRotationTime = 0f;
            toRotate = false;
        }
    }
}
