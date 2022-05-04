using System.Collections.Generic;
using UnityEngine;
using System;

public class Move : MonoBehaviour
{
    Vector3 Mytransform;
    //bool movecheck = false;


    Rigidbody Myrigid;
    [Range(5, 20)] public float _MovePower = 15;
    [Range(5, 20)] public float _JumpPower = 5;

    Vector3 normalizedVector; // �븻������ ����

    bool jumpstate = false;

    private Dictionary<KeyCode, Vector3> keyValuePairs = new Dictionary<KeyCode, Vector3>();

    void Start()
    {
        AddDictionary();
        Mytransform = this.gameObject.transform.position;
        Myrigid = GetComponent<Rigidbody>();
        Myrigid.MovePosition(Mytransform);  // ���� ������Ʈ�� �ʱ� ��ġ�� �̵�
    }


    void FixedUpdate()
    {
        Mytransform = transform.position;

        if (Input.anyKey)
        {
            KeySetting();
        }
    }

    private void OnCollisionEnter(Collision other) // �ٴ� ���� ���� -> ����ĳ��Ʈ ������� ���濹��
    {
        if (other.gameObject.layer == 8)
        {
            Debug.Log("���� ��ҽ��ϴ�.");
            jumpstate = !jumpstate;
        }
    }

    void KeySetting()
    {
        foreach(var dic in keyValuePairs)
        {
            if(Input.GetKey(dic.Key))
            {
                vector_Normalized(dic.Value);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpstate == true)
        {
            jumpstate = !jumpstate;
            Myrigid.AddForce(Vector3.up * _JumpPower, ForceMode.Impulse); // ��� �������� �̵�����
        }

    }

    void vector_Normalized(Vector3 vector3)
    {
        normalizedVector = vector3.normalized * _MovePower * Time.deltaTime; //�밢�� �������� �ε巴�� �ϱ����� ���� �븻������ ����
        Mytransform += normalizedVector;
        Myrigid.MovePosition(Mytransform);


        // ���� �浹 ����, ���� ��ǥ��� �̵��� ���������� ���� �̵� ����
    }

    public void AddDictionary()
    {
        keyValuePairs.Add(KeyCode.W, transform.forward);
        keyValuePairs.Add(KeyCode.A, -transform.right);
        keyValuePairs.Add(KeyCode.S, -transform.forward);
        keyValuePairs.Add(KeyCode.D, transform.right);
    }

}
