using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    public Vector3 offset;

    public float smoother;

    //private void Start()
    //{
    //    offset.Set(0, 6, -10);
    //}

    void FixedUpdate()
    {
        Vector3 desiredpos = target.position + offset;
        Vector3 smoothedpos = Vector3.Lerp(transform.position, desiredpos, 0.4f);
        transform.position = smoothedpos;

        transform.LookAt(target);
    }

}
