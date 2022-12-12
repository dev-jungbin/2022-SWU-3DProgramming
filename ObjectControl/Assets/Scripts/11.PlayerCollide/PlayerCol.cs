using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCol : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        print("충돌");
        // 에너미 or 에너미 총알과 충돌했다면
        if (other.tag == "Enemy" || other.tag == "EnemyBullet") {
            // 카메라 분리 (카메라 사라짐 방지)
            Camera.main.transform.SetParent(null);
            // 오브젝트 색을 회색으로 변경
            GetComponent<MeshRenderer>().material.color = Color.gray;
            Invoke("Die", 1); // 1초 후 사망 처리
        }
    }

    void Die() {
        gameObject.SetActive(false); // 플레이어 오브젝트 비활성화
    }
}
