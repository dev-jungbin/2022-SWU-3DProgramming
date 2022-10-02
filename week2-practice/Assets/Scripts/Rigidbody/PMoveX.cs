using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMoveX : MonoBehaviour
{
    public float power = 0.1f; // 힘의 크기
    Rigidbody rb; // 강체 인스턴스
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 강체 컴포넌트 얻기
    }

    // Update is called once per frame
    void FixedUpdate() // 고정되어 있는 업데이트. 갱신 주기가 0.02초임. 그냥 Update는 더 빨리 호출됨. 간격도 불규칙함. 물리를 처리할 때에는 FixedUpdate를 사용해 일정 시간 간격으로 처리해야 함
    {
        float hor = Input.GetAxis("Horizontal"); // 수평 방향키 입력 (-1.0 ~ 1.0)
        float impulse = hor * power; // 힘 계산
        rb.AddRelativeForce(impulse, 0, 0, ForceMode.Impulse); // X축으로 imp의 힘을 가함
    }
}
