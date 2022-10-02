using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMoveZWheel: MonoBehaviour
{

    public float power = 0.1f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mw = Input.GetAxis("Mouse ScrollWheel");
        float impulse = mw * power;
        rb.AddRelativeForce(0, 0, impulse, ForceMode.Impulse);
    }
}
