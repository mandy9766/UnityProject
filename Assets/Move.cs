using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {   //1. MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);

        //2.SmoothDamp ref -> 참조, 실시간으로 변하는 속도 넣을 수 있다.
        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.5f);

        //3. Lerp = 선형 보간. smoothDamp보다 감속 시간이 길다.
        //transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        //4. Slerp (구면선형보간)
        //transform.position = Vector3.Slerp(transform.position, target, 0.01f);

    }   
}
