using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Coroutine st;
    
    // Start is called before the first frame update
    void Start()
    {
        st = StartCoroutine(ShowTime(2)); // ShowTime 코루틴 실행
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
