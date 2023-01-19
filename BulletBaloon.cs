using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBaloon : MonoBehaviour
{
    [SerializeField] private AudioSource Destro;
    public float life = 3;
    public float Grow;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tors")
        {
            Destro.Play();
            transform.localScale -= new Vector3(Grow, Grow, Grow);
            Destroy(collision.gameObject);
        }
    }
}
