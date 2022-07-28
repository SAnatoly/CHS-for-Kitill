using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapFireGun : MonoBehaviour
{

    public float distance;
    public GameObject targetObjectForDistance;
    public bool isGrab;
    public Transform newParentl;
    public GameObject particly;
    public GameObject posPoint;
    // Start is called before the first frame update
    void Start()
    {
        particly.SetActive(false);
        newParentl = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, targetObjectForDistance.transform.position);

        if(distance <= 6f)
        {
            if (Input.GetKey(KeyCode.F))
            {
                isGrab = true;
                targetObjectForDistance.transform.rotation = posPoint.transform.rotation;
                targetObjectForDistance.transform.position = posPoint.transform.position;
                targetObjectForDistance.transform.SetParent(newParentl);
            }
        }

        if(isGrab && Input.GetMouseButtonDown(0))
        {
            particly.SetActive(true);
        }

        if (isGrab && Input.GetMouseButtonUp(0))
        {
            particly.SetActive(false);
        }
    }
}
