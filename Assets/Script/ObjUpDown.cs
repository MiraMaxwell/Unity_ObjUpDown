using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjUpDown : MonoBehaviour
{
    //private Transform attacher;
    //public int hight = 1;//max height of Box's movement
    //public float yCenter = 0f;

    public float height;
    public float speed;

    Vector3 ppos;

    void Start()
    {
        //attacher = this.transform.Find("SmashBoxAttacher");

        ppos = transform.position;
    }

    void Update()
    {
        //transform.position = new Vector3(transform.position.x, yCenter + Mathf.PingPong(Time.time , hight), transform.position.z);//move on y axis only

        this.transform.position = new Vector3(this.transform.position.x, Mathf.Sin(Time.time * speed) * height + ppos.y, this.transform.position.z);                                                                                                                     
    }
}
