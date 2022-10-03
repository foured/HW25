using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float offset;
    public void Move()
    {
        transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
    }
}
