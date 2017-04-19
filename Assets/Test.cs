using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        //进入触发器执行的代码
        Debug.Log("trigger");
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        //进入碰撞器执行的代码
    }
}
