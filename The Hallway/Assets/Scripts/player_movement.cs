using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 5f;
    [SerializeField] float RotateSpeed = 10f;
    private void Update()
    {
        Vector2 input = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            input.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input.x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;
        }

        input = input.normalized;
        Vector3 moveDir = new Vector3(input.x, 0, input.y);

        transform.position += moveDir * PlayerSpeed * Time.deltaTime;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * RotateSpeed);
        if (Input.GetKeyDown (KeyCode.Q))
        {
            Debug.Log("Recharging!");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Switching item in hand");
        }


    }   
}
