using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCol : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        // 플레이어 총알과 충돌했다면
        if (other.tag == "PlayerBullet") {
            // 오브젝트 색을 검은색으로 변경
            GetComponent<MeshRenderer>().material.color = Color.black;
            Invoke("Die", 1); // 1초 후 사망 처리
        }
    }

    void Die() {
        gameObject.SetActive(false); // 플레이어 오브젝트 비활성화
    }
}
