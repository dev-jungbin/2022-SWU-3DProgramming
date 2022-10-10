using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShowTime", 2); // 2초 후에 ShowTime 함수 실행
    }

    // Update is called once per frame
    void ShowTime()
    {
        print("2초 경과");
    }
}
