using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        //����
        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);

        //�׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        
        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        

        //������

        string title = "������";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = (level == fullLevel);
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        //��Ȳ������
        int health = 30;
        int mana = 25;

        bool isBadCondition = (health <= 50 || mana <= 20);
        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ������� ���޴ϱ�?" + " " + condition);

        //Ű����


    }
    
}
