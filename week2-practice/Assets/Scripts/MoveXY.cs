using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXY : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        // 모든 이동 방향에 대해 속도를 동일하게 조절
        if (dir.magnitude > 1) { // 벡터의 길이가 1보다 크다면
            dir.Normalize(); // 벡터 길이를 1로 변경
        }

        float len = speed * Time.deltaTime; // 이동 거리 계산
        transform.Translate(dir * len); // dir 방향으로 len만큼 이동
    }
}
