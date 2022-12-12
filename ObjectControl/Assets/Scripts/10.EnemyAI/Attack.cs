using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float limitDist = 5; // 공격 가능 거리
    public float interval = 1; // 공격 지연 시간
    public GameObject bullet; // 총알 프리팹
    Transform playerPos; // 플레이어 위치
    bool isFire = false; // 사격 상태 여부

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player"); // 태그로 플레이어 찾기
        playerPos = player.transform; // 플레이어 위치
    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어와의 거리 계산
        float dist = (playerPos.position - transform.position).magnitude;

        // 공격 거리 안이라면
        if (dist < limitDist) {
            // 사격 상태가 아니라면
            if (isFire == false) {
                BeginFire(); // 사격 개시
            }
            // 사격 상태 표시
            Debug.DrawLine(playerPos.position, transform.position, Color.red);
        }
    }

    void BeginFire() {
        isFire = true; // 사격 상태 시작

        Vector3 dist = playerPos.position - transform.position; // 에너미 -> 플레이어 방향
        Quaternion targetRot = Quaternion.LookRotation(dist); // 총알 생성

        Instantiate(bullet, transform.position, targetRot); // 총알 생성
        Invoke("EndFire", interval); // interval초 후, 사격 상태 해제
    }

    void EndFire() {
        isFire = false; // 사격 상태 해제
    }
}
