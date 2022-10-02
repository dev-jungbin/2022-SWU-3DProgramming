using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisWheel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 휠 스크롤
        float mw = Input.GetAxis("Mouse ScrollWheel");

        if (mw != 0) {
            Debug.Log("mw = " + mw);
        }
    }
}
