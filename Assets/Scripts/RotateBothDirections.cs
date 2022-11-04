using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBothDirections : MonoBehaviour
{
    public bool isLocked = false;
    public bool isClosed = true;
    public Transform doorTransform;
    public float openingAngle = 90f;
    public float openingSpeed = 2f;
    public int openingDirection = 1;
    public float closedRotation;
    public float finalRot = 90f;
    public bool inMotion = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UseDoor();        
        }
    }

    public bool UseDoor()
    {
        if (!inMotion && !isLocked)
        {
            if (!isClosed)
            {
                Debug.Log("Open door");
                openingDirection = 1;
            }
            else
            {
                Debug.Log("Close door");
                openingDirection = -1;
                
            }
            inMotion = true;
            ActivateDoor();
        }
        return !isClosed;
    }

    void ActivateDoor()
    {
        StartCoroutine(DoorRotation());
        isClosed = !isClosed;
    }

    IEnumerator DoorRotation()
    {
        float acumulatedRotation = 0f;
        while (Mathf.Abs(acumulatedRotation) < finalRot)
        {
            doorTransform.Rotate(0, openingSpeed * openingDirection, 0);
            acumulatedRotation += openingSpeed;
            Debug.Log(doorTransform.eulerAngles.y);
            yield return new WaitForEndOfFrame();
        }
        inMotion = false;
    }
    
}
