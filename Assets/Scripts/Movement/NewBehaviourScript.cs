using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool is_ground = false;     //���������� ������� ������ � ���� ��������, "�� ����� �� �����"
    Rigidbody player;         //��� ��� �� ����� ���������� � ������, �� �� ������ ����� ������������ ���� ���������
    public float force = 6;     //���� � ������� ����� ������� ��������

    void Start()
    {
        player = GetComponent<Rigidbody>(); //��� ������ �����, �������� ��������� � ��������� � ����������
    }

    void OnTriggerStay(Collider col)
    {               //���� � ������� ��� �� ���� � � ������� ��� "ground"
        if (col.tag == "ground") is_ground = true;      //�� �������� ���������� "�� �����"
    }
    void OnTriggerExit(Collider col)
    {              //���� �� �������� ��� �� ����� � � ������� ��� "ground"
        if (col.tag == "ground") is_ground = false;     //�� ��������� ���������� "�� �����"
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)               //���� ������ ������ "������" � ����� �� �����
            player.AddForce(Vector2.up * force, ForceMode.Impulse);   //�� ������� ��� ���� ����� ���������� ������
    }
    
}
