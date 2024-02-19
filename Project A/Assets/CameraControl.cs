using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float Sensivinity;
    float senY;
    float senX;
    public Transform PlayerBody;
    bool took;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * Sensivinity;
        float y = Input.GetAxis("Mouse Y") * Sensivinity;
        senY -= y;
        senX += x;
        senY = Mathf.Clamp(senY, -90f, 90f);
        PlayerBody.localRotation = Quaternion.Euler(0f, senX, 0f);
        transform.localRotation = Quaternion.Euler(senY,0f,0f);
    }
}
