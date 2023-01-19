using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private AudioSource Finish;
    public Transform door;
    private Vector3 openRot;
    private Vector3 defaultRot;

    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;

    private void Start()
    {
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.z + DoorOpenAngle, defaultRot.y);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            Finish.Play();
            DoorActiv();
        }
    }

    private void DoorActiv()
    {
        door.transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
    }
}
