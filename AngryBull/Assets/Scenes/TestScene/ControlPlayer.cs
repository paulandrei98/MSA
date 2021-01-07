using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer
 : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float rotationSpeed = 280.0f;
    float horizontal;
    float vertical;

    public void Update()
    {
       Vector3 moveDirection = Vector3.forward * vertical + Vector3.right * horizontal;

       Vector3 projectCameraForward = Vector3.ProjectOnPlane(Camera.main.transform.forward,Vector3.up);
       Quaternion rotationToCamera = Quaternion.LookRotation(projectCameraForward, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToCamera, rotationSpeed*Time.deltaTime);

       moveDirection = rotationToCamera * moveDirection;

       transform.position += moveDirection * moveSpeed * Time.deltaTime; 
    }

    public void OnMoveInput(float horizontal, float vertical)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
        Debug.Log($"Player Controll Move Input: {vertical},{horizontal}");
    }
}
