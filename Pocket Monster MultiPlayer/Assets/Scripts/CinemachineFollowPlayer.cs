using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineFollowPlayer : MonoBehaviour
{

    public CinemachineVirtualCamera vcam;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        if (!target)
        {
            //target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        //vcam.Follow = target;
    }
}
