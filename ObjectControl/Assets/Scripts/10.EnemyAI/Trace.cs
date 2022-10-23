using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trace : MonoBehaviour
{
    public float limitDist = 10; // 추적 가능 거리
    Transform playerPos; // 플레이어 위치
    NavMeshAgent nma; // NavMeshAgent 인스턴스

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player"); // 태그로 플레이어 찾기
        playerPos = player.transform; // 플레이어 위치
        nma = GetComponent<NavMeshAgent>(); // NavMeshAgent 컴포넌트 얻기
    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어와의 거리 계산
        float dist = (playerPos.position - transform.position).magnitude;

        if (dist < 3) { // 거리가 3 미만이면 
            nma.isStopped = true; // 정지함
        } else if (dist < limitDist) // 추적 거리 안이라면
        {
            nma.isStopped = false; // 이동함
            nma.SetDestination(playerPos.position); // 플레이어 위치를 목표 지점으로 설정
            Debug.DrawLine(playerPos.position, transform.position, Color.blue); // 추적 상태 표시
        }
    }
}
