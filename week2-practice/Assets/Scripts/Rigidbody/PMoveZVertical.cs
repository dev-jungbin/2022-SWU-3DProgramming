using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMoveZVertical: MonoBehaviour
{

    public float power = 0.1f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float ver = Input.GetAxis("Vertical");
        float impulse = ver * power;
        rb.AddRelativeForce(0, 0, impulse, ForceMode.Impulse);
    }
}
