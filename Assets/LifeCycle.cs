using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    //초기화 영역
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비 되었습니다.");  
    }

    // 활성화 - 게임 오브젝트가 활성화 될때
    private void OnEnable()
    {
        Debug.Log("플레이어 로그인 되었습니다.");
    }
    // 초기화 (활성화 이후 실행)
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    


    //물리연산 업데이트 = 물리연산 전에 실행되는 함수, 고정된 실행주기로 CPU 많이 사용된다. - 사용자 cpu에 따라 속도 다름 보통 50 
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }
    // 게임 로직 업데이트 (물리연산 제외 주기적으로 변하는 요소) - 60프레임 속도
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }
    //모든 업데이트 이후 실행 ( 카메라 or 후처리 등 )
    private void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }
    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    private void OnDestroy()
    {
        Debug.Log("플레이어 데이터가 해제 되었습니다.");
    }

}
