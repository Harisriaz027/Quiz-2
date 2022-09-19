using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 0;
        transform.LookAt(mousePos);

        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<playerFollow>().canDie = true;
            Vector3 pushBack = (other.transform.position - transform.position);
            other.GetComponent<Rigidbody>().AddForce(pushBack*4, ForceMode.VelocityChange);
                Debug.Log("working");
               
            }
        }
        
    }
}
