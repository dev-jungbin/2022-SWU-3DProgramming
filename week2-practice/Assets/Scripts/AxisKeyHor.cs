using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisKeyHor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 수평 방향키 입력 (-1.0 ~ 1.0)
        float hor = Input.GetAxis("Horizontal");

        if (hor != 0) {
            print("hor = " + hor);
        }
    }
}
