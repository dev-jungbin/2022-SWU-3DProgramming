using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    public GameObject bullet; // 총알 프리팹
    public Transform shotPos; // 발사 위치 & 방향

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // 마우스 좌측 버튼 클릭 시
            // 총알 생성 및 위치 & 방향 초기화
            Instantiate(bullet, shotPos.position, shotPos.rotation);
        }
    }
}
