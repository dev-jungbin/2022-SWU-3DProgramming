using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        // Time.deltaTime 곱하는 이유: 프레임 문제로 컴퓨터 성능에 따라 속도가 달라지는 걸 방지하기 위함
        float len = hor * speed * Time.deltaTime; // 이동 거리

        transform.Translate(len, 0, 0); // X축으로 len 만큼 이동
    }
}
