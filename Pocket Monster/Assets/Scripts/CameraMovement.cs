using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform Player;

    void FixedUpdate() 
    {
        // Sætter kameraet position til spillerens position.
        transform.position = new Vector3(Player.position.x,Player.position.y,transform.position.z);
    }
}
