using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] goals; // 순찰 위치들
    NavMeshAgent nma; // NavMeshAgent 인스턴스

    void Start()
    {
        nma = GetComponent<NavMeshAgent>(); // NavMeshAgent 컴포넌트 얻기
        SelectGoal(); // 이동 목표 지정    
    }

    // Update is called once per frame
    void Update()
    {
        if (nma.remainingDistance < 0.5f) // 목표 근처라면
            SelectGoal();
    }

    void SelectGoal() {
        int goalIdx = Random.Range(0, this.goals.Length); // 이동 목표 랜덤 선택
        nma.SetDestination(this.goals[goalIdx].position); // 선택된 이동 목표 지정
    }
}
