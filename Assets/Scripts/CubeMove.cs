using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public Vector3 target;
    public float speed;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            target,
            speed * Time.fixedDeltaTime);
        if (transform.position == target)
        {
            Destroy(this.gameObject);
        }
    }
}
