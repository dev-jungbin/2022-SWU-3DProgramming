using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShowTime", 1, 2); // 1초 후 2초마다 showTime 실행
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))   
            CancelInvoke("ShowTime"); // ShowTime 인보크 중단
        else if (Input.GetKeyDown("2"))
            CancelInvoke(); // 모든 인보크 중단
    }

    void ShowTime() {
        print("2초 경과");
    }
}
