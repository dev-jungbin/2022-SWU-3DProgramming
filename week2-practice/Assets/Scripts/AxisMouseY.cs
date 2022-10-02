using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisMouseY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 수직 이동
        float my = Input.GetAxis("Mouse Y");

        if (my != 0) {
            print("my = " + my);
        }
    }
}
