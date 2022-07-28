using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedTriggerObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Destroyed());
    }

    // Update is called once per frame
    void Update()
    {
      // transform.Translate(transform.forward);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            Destroy(other.gameObject);
        }
    }

    public IEnumerator Destroyed()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
