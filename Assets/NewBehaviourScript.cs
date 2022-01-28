using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        //변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        //그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //한글확인
        
        //연산자

        string title = "전설의";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = (level == fullLevel);
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        //상황연산자
        int health = 30;
        int mana = 25;

        bool isBadCondition = (health <= 50 || mana <= 20);
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 컨디션은 나쁩니까?" + " " + condition);

        //키워드


    }
    
}
