using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJump : MonoBehaviour
{
    public float power = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 정지 상태이고, 점프 버튼(스페이스바)을 누르면
        if (Mathf.Abs(rb.velocity.y) < 0.001f && Input.GetButtonDown("Jump")) // 0.001f 처리를 안하면 진동이 생길 수 있음. 0.001로 처리해줘야 안정적임
            rb.AddForce(0, power, 0, ForceMode.Impulse); // Y축 방향으로 power의 힘을 가함
    }
}
