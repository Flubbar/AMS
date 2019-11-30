using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : PlayerMove.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어를 키보드로 조작할 수 있게 해준다.

*/


public class PlayerMove : MonoBehaviour
{
	public float movementSpeed = 10f;

	private CharacterController charController;

	private void Awake()
	{
		charController = GetComponent<CharacterController>();
	}

	private void Update()
	{
		float horizInput = Input.GetAxis("Horizontal") * movementSpeed;
		float vertInput = Input.GetAxis("Vertical") * movementSpeed;

		Vector3 forwardMovement = transform.forward * vertInput;
		Vector3 rightMovement = transform.right * horizInput;

		Vector3 moveDir = forwardMovement + rightMovement;
		moveDir += Physics.gravity;

		charController.Move(moveDir * Time.deltaTime);
	}

}