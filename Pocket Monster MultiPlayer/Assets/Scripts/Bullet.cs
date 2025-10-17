using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class Bullet : MonoBehaviourPun
{
    public float lifeDuration = 0.2f;
    public float lifeTimer;

    void Start() {
        lifeTimer = lifeDuration;
    }

    void Update()
    {
        // Tjekker om skuddet skal ødelægges.
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f) {
            PhotonNetwork.Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        PhotonNetwork.Destroy(gameObject);
    }

}
