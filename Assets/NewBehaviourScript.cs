using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Hello Unity");

        //1.����
    int level = 5;
        float strength = 15.5f;
    string playername = "�輱ȣ";
    bool isFullLevel = false;

        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� �̸���?");
        Debug.Log(playername);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);

        //2.�׷��� ����
        string[] monsters = { "������", "�̽�ȣ", "�ۿ���" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        //3.������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playername);

        int fulllevel = 99;
        isFullLevel = level == fulllevel;
        Debug.Log("���� �����ΰ�?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 && mana <= 20;
        

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���°� ���޴ϱ�?" + condition);

        //5.���ǹ�
        if(condition == "����"){
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }
        if (isBadCondition && items[0] == "��������30") {
           items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
    }
}
