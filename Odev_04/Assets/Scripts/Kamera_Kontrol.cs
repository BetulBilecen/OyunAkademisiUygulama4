using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Kontrol : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 100f;
    public GameObject player; //Kameranýn baðlý olduðu nesne


    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity; //X kordinatýný ayarladýk
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity; //Y kordinatýný ayarladýk
        
        xRotation -= mouseY; //mouse ile yukarý aþaðý dönmemizi saðlar
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // mouse'un döneceði açý aralýðý
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0); //X ekseninde gezinmek için

        player.transform.Rotate(Vector3.up * mouseX);
    }
}
