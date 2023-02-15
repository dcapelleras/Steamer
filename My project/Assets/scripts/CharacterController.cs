using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    float inputX;
    float inputZ;

    private void Update()
    {
        if (GetInput() != Vector3.zero)
        {
            transform.position += GetInput() * moveSpeed * Time.deltaTime;
        }
    }

    Vector3 GetInput()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(inputX, 0f, inputZ);
        return movement;
    }
}
