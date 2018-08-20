using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private int speed = 5;

    private int rotationSpeed = 5;



    private void Update()
    {
        if (Input.GetButton("Forward"))
        {
            // Debug.Log("Up Key is pressed");
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetButton("Back"))
        {
            transform.Translate(Vector3.forward * -speed * Time.deltaTime, Space.Self);
        }

        if (Input.GetButton("Right"))
        {
            transform.Rotate(Vector3.up, rotationSpeed);
        }
        else if (Input.GetButton("Left"))
        {
            transform.Rotate(Vector3.up, -rotationSpeed);
        }
    }






    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }

   

}
