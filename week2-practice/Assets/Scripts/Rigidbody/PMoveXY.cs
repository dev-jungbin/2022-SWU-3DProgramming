using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMoveXY : MonoBehaviour
{

    public float power = 0.1f;
    Vector3 dir;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        if (dir.magnitude > 1)
            dir.Normalize();

        rb.AddRelativeForce(dir * power, ForceMode.Impulse);
    }
}
