using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, -1 * Input.GetAxis("Vertical"));
        Vector3 speedCoefficient = playerInput * Time.deltaTime * speed;
        transform.Translate(speedCoefficient);
    }
}
