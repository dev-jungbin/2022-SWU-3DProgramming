using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAI : MonoBehaviour
{
    public Transform goal; // 목표 지점 위치
    NavMeshAgent nma; // NavMeshAgent 인스턴스
    void Start()
    {
        // NavMeshAgent 컴포넌트 얻기
        nma = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // 에이전트의 목표 지점과 goal 위치가 다르다면
        if (nma.destination != goal.position) {
            nma.SetDestination(goal.position); // 목표 지점을 goal 위치로 변경
        }
    }
}
