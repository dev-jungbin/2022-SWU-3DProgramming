using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSpinY : MonoBehaviour
{
    public float power = 1;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() // ����� �� �׳� ������Ʈ��? Ű����� ���������� �Էµ�. ���콺�� ���������� �Է� �� ��. �Ʊ� �Ƚ��� ������Ʈ�� Ű���� ���� �Է� ���� �� ����ߴµ�, ���콺�� ���������� �Է� �� �Ǵϱ� �׳� update�� ��� ��
    {
        float mx = Input.GetAxis("Mouse X");
        float imp = mx * power;

        rb.AddRelativeTorque(0, imp, 0, ForceMode.Impulse);
    }
}
