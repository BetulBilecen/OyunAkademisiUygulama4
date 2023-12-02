using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Kontrol : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 100f;
    public GameObject player; //Kameran�n ba�l� oldu�u nesne


    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity; //X kordinat�n� ayarlad�k
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity; //Y kordinat�n� ayarlad�k
        
        xRotation -= mouseY; //mouse ile yukar� a�a�� d�nmemizi sa�lar
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // mouse'un d�nece�i a�� aral���
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0); //X ekseninde gezinmek i�in

        player.transform.Rotate(Vector3.up * mouseX);
    }
}
