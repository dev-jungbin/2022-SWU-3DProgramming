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
    void Update() // 여기는 왜 그냥 업데이트야? 키보드는 지속적으로 입력됨. 마우스는 지속적으로 입력 안 됨. 아까 픽스드 업데이트에 키보드 지속 입력 받을 때 사용했는데, 마우스는 지속적으로 입력 안 되니까 그냥 update를 써야 됨
    {
        float mx = Input.GetAxis("Mouse X");
        float imp = mx * power;

        rb.AddRelativeTorque(0, imp, 0, ForceMode.Impulse);
    }
}
