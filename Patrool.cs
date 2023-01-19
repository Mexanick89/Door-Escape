using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrool : MonoBehaviour
{
    public float speed = 3f;
    public Transform[] points;
    public int i;

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, points[i].position) < 0.2f)
        {
            if(i>0)
            {
                i=0;
            }
            else
            {
                i=1;
            }
        }
    }
}
