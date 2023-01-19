using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private AudioSource shootgun;
    public Transform bulletSpawnPoint;
    public GameObject ShootPrefab;
    public float bulletSpeed = 10;
    public Transform Iwolk;
    public float speedball = 1;
    public float speed = 3;

    public void Shooting()
    {
        shootgun.Play();
        //Iwolk.transform.Translate(transform.position * Time.deltaTime);
        Iwolk.transform.Translate(Vector3.right * Time.deltaTime * speed);
        var bullet = Instantiate(ShootPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
