using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
	public Transform playerBody;
	public float speed = 100f;
	float xRotation = 0F;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
	{
		float mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
		xRotation -= mouseY;

		xRotation = Mathf.Clamp(xRotation, -90f ,90f);
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		playerBody.Rotate(Vector3.up * mouseX);
	}
}

