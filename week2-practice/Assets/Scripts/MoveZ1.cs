using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ1 : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float len = ver * speed * Time.deltaTime; // 이동 거리

        transform.Translate(0, 0, ver); // Z축으로 len 만큼 이동
    }
}
