using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{ 
    public float force = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("PushBack");

            Vector3 pushDirection = other.transform.position - transform.position;

            pushDirection = -pushDirection.normalized;

            GetComponent<Rigidbody>().AddForce(pushDirection * force * 100);

        }
    }
}
