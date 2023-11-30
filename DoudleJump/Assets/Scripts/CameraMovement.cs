using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    float cameraMoveSpeed = 0.25f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * cameraMoveSpeed * Time.fixedDeltaTime);

        cameraMoveSpeed += 0.1f * Time.deltaTime;
    }
}
