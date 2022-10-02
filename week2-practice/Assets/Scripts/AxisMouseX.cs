using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisMouseX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 수평 이동
        float mx = Input.GetAxis("Mouse X");

        if (mx != 0) {
            print("mx = " + mx);
        }
    }
}
