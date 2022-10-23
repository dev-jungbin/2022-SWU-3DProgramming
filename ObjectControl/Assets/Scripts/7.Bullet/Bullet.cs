using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 speed; // 이동 속도

    void Start()
    {
        Destroy(gameObject, 3); // 3초 후 제거        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dis = speed * Time.deltaTime; // 이동 거리
        transform.Translate(dis); // dis 만큼 이동
    }

    void OnTriggerEnter(Collider other) {
        Destroy(gameObject); // 충돌 시 제거
    }
}
