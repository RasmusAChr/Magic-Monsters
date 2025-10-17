using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Photon.Pun;

public class Shooting : MonoBehaviourPun
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public float autoCooldownTime = 0.5f;
    private float autoNextFireTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > autoNextFireTime)
            {
                Shoot();
                autoNextFireTime = Time.time + autoCooldownTime;
            }
        }
    }

    void Shoot()
    {
        if (photonView.IsMine)
        {
            GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
