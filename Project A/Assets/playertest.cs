using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertest : MonoBehaviour
{
    float x; float y;
    public float DesiredSpeed;
    public CharacterController Controller;
    private void FixedUpdate()
    {
        // inputs
        x = Input.GetAxisRaw("Horizontal"); y = Input.GetAxisRaw("Vertical");
        // movement
        Vector3 Direction = transform.forward * y + transform.right * x;
        Controller.Move(Direction* DesiredSpeed*Time.fixedDeltaTime);
        Controller.Move(Vector3.down * ((98f * Time.fixedDeltaTime) * Time.deltaTime));
    }
}
