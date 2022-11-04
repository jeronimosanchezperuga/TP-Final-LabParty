using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isLocked = false;
    public bool isClosed = true;
    public Transform doorTransform;
    public float openingAngle = 90f;
    public float openingSpeed = 2f;
    public int openingDirection = 1;
    public float closedRotation;
    public float finalRot;
    public bool inMotion = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Open()
    {        
        if (!inMotion && isClosed && !isLocked)
        {
            Debug.Log("Open door");
            inMotion = true;
            isClosed = false;
            OpenRotateDoor();
            
        }
        return !isClosed;
    }

    public bool Close()
    {
        if (!inMotion && !isClosed)
        {
            Debug.Log("Close door");
            inMotion = true;
            isClosed = true;
            CloseRotateDoor();            
        }
        return isClosed;
    }

    void OpenRotateDoor()
    {
        closedRotation = doorTransform.localEulerAngles.y;
        finalRot = closedRotation + openingAngle * openingDirection;
        StartCoroutine(OpenRotation());
    }
    void CloseRotateDoor()
    {        
        StartCoroutine(CloseRotation());
    }

    IEnumerator OpenRotation()
    {
        Debug.Log("Open coroutine");
        while (doorTransform.localEulerAngles.y < finalRot * openingDirection)
        {
            doorTransform.Rotate(0, openingSpeed * openingDirection, 0);
            Debug.Log(doorTransform.eulerAngles.y);
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Open coroutine end");
        inMotion = false;
    }
    IEnumerator CloseRotation()
    {
        while (doorTransform.localEulerAngles.y > closedRotation + 1)
        {
            doorTransform.Rotate(0, -openingSpeed * openingDirection, 0);
            Debug.Log(doorTransform.eulerAngles.y);
            yield return new WaitForEndOfFrame();
        }
        doorTransform.localEulerAngles = new Vector3(0, closedRotation, 0);
        inMotion = false;
    }
}
