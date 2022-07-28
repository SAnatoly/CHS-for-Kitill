using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speedMove = 5;
    public int speedRotate = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * speedMove);
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * speedRotate, 0);
    }
}
