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
        float x = Input.GetAxis("Horizontal");//让系统知道玩家按下了方向键的左右
        float z = Input.GetAxis("Vertical");//让系统知道玩家按下了方向键的前后
        Vector3 f = new Vector3(x,0,z);//把玩家的输入操作打包在一个力f里面
        r.AddForce(f*5);//给小球施加力f
    }
}
