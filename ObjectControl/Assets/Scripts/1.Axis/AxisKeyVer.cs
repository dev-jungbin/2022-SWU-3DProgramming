using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisKeyVer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 수직 방향키 입력 (-1.0 ~ 1.0)
        float ver = Input.GetAxis("Vertical");

        if (ver != 0) {
            print("ver = " + ver);
        }
    }
}
