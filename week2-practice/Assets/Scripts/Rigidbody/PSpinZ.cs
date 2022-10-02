using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSpinZ : MonoBehaviour
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
        float my = Input.GetAxis("Mouse ScrollWheel");
        float imp = my * power;

        rb.AddRelativeTorque(0, 0, imp, ForceMode.Impulse);
    }
}
