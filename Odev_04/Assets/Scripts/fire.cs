using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class fire : MonoBehaviour
{
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(Physics.Raycast(Camera.main.transform.position,transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                    Destroy(hit.collider.gameObject);
            }
        }
    }
}
