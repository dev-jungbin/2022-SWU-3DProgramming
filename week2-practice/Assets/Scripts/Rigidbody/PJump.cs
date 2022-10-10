using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJump : MonoBehaviour
{
    public float power = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �����̰�, ���� ��ư(�����̽���)�� ������
        if (Input.GetButtonDown("Jump")) // 0.001f ó���� ���ϸ� ������ ���� �� ����. 0.001�� ó������� ��������
            rb.AddForce(0, power, 0, ForceMode.Impulse); // Y�� �������� power�� ���� ����
    }
}
