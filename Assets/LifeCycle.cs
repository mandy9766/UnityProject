using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    /* 

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


    */
    
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다");
        if(Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다");

        // 키보드 버튼 클릭
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 이동을 멈췄습니다.");

        // 마우스 버튼 클릭
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!");


        // 버튼 매핑은 유니티에서 edit - project settings - input manager로 바꾸면 된다.
        // 버튼 매핑한 것 사용하기
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중....");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼점프!!");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡이동중...." + Input.GetAxisRaw("Horizontal"));
        }

        
        // 캐릭터 이동

        // Time.deltaTime -> 이전 프레임을 돌리는데 걸리는 시간 ( 컴퓨터마다 다르니까 이걸 써줘야 이걸 맞춰줘야함)
        // translate  : 벡터에 곱하기 -> transform.Translate(Vec*Time.deltaTime);
        // OR
        // 벡터함수 : 시간매개변수에 곱하기 -> Vector3.Lerp(Vec1,Vec2,T*Time.deltaTime);

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")*1f,0, Input.GetAxis("Vertical") * 1f);
        
        transform.Translate(vec*Time.deltaTime);


    }
    

}
  