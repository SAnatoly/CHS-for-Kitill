using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceTriggerObject : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(prefab, transform);
    }
}
