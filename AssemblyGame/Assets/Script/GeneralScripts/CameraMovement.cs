using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float timeToRotate = 20f;
    public float angleToRotate = 0f;
    public Transform doorPos;

    float currentRotationTime = 0f;
    float currentTranslationTime = 0f;
    float currentAngle = 0f;
    bool toRotate = false;

    public Animator compass;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        currentAngle = transform.rotation.eulerAngles.y;

        if (angleToRotate < 0)
        {
            angleToRotate = 270;
        }
        else if (angleToRotate >= 360)
        {
            angleToRotate = 0;
        }

        if(Input.mousePosition.x <= 50 && !toRotate)
        {
            gameObject.GetComponent<AudioSource>().Play();
            toRotate = true;
            angleToRotate = currentAngle - 90f;
        }

        if (Input.mousePosition.x >= 1870 && !toRotate)
        {
            gameObject.GetComponent<AudioSource>().Play();
            toRotate = true;
            angleToRotate = currentAngle + 90f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !toRotate)
        {
            gameObject.GetComponent<AudioSource>().Play();
            toRotate = true;
            angleToRotate = currentAngle - 90f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !toRotate)
        {
            gameObject.GetComponent<AudioSource>().Play();
            toRotate = true;
            angleToRotate = currentAngle + 90f;
        }
        
        compass.SetInteger("current_angle", (int)angleToRotate);

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

            //Debug.Log("Current angle: " + currentAngle);
            //Debug.Log("Angle to rotate: " + angleToRotate);
        }
        else
        {
            transform.rotation = Quaternion.AngleAxis(angleToRotate, Vector3.up);
            currentRotationTime = 0f;
            toRotate = false;
        }
    }

    public IEnumerator StartZoomingIn()
    {
        while(transform.GetComponent<Camera>().orthographicSize > 1.2)
        {
            //Debug.Log("Hello I should be fucking interpolating but im not");
            currentTranslationTime += Time.deltaTime;
            transform.GetComponent<Camera>().orthographicSize = Mathf.Lerp(transform.GetComponent<Camera>().orthographicSize , 1, currentTranslationTime);
            transform.position = Vector3.Lerp(transform.position, doorPos.position, currentTranslationTime);
            yield return new WaitForEndOfFrame();
        }
        //Debug.Log("I should stop now");
        currentTranslationTime = 0f;
    }

    public IEnumerator StartZoomingOut()
    {
        while (transform.GetComponent<Camera>().orthographicSize < 5.35f)
        {
            //Debug.Log("Hello I should be fucking interpolating but im not");
            currentTranslationTime += Time.deltaTime * 0.5f;
            transform.GetComponent<Camera>().orthographicSize = Mathf.Lerp(transform.GetComponent<Camera>().orthographicSize, 5.35f, currentTranslationTime);
            yield return new WaitForEndOfFrame();
        }
        currentTranslationTime = 0f;
    }
}
