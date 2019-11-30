using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : PlayerLook.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어의 시점을 마우스로 조절 가능하게 한다.

*/


public class PlayerLook : MonoBehaviour
{
	public float mouseSensitivity = 1f;

	public Transform playerBody;

	private float xAxisClamp;

	private void Awake()
	{
		LockCursor();
		xAxisClamp = 0.0f;
	}


	private void LockCursor()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		CameraRotation();
	}

	private void CameraRotation()
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		xAxisClamp += mouseY;

		if (xAxisClamp > 90.0f)
		{
			xAxisClamp = 90.0f;
			mouseY = 0.0f;
			ClampXAxisRotationToValue(270.0f);
		}
		else if (xAxisClamp < -90.0f)
		{
			xAxisClamp = -90.0f;
			mouseY = 0.0f;
			ClampXAxisRotationToValue(90.0f);
		}

		transform.Rotate(Vector3.left * mouseY);
		playerBody.Rotate(Vector3.up * mouseX);
	}

	private void ClampXAxisRotationToValue(float value)
	{
		Vector3 eulerRotation = transform.eulerAngles;
		eulerRotation.x = value;
		transform.eulerAngles = eulerRotation;
	}
}