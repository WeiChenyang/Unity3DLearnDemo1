using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");//��ϵͳ֪����Ұ����˷����������
        float z = Input.GetAxis("Vertical");//��ϵͳ֪����Ұ����˷������ǰ��
        Vector3 f = new Vector3(x,0,z);//����ҵ�������������һ����f����
        r.AddForce(f*5);//��С��ʩ����f
    }
}
