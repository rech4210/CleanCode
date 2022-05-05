using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GravityTest : MonoBehaviour
{
    List<Rigidbody> rigidbody_list = new List<Rigidbody>();

    public GameObject[] GravityTools;
    public GameObject[] GravityBall;
    public float[] myData = new float[18];
    public struct Mygravity
    {
        public float mass;
        public float drag;
        public float angular;

        public Mygravity(float mass, float drag, float angular)
        {
            this.mass = mass;
            this.drag = drag;
            this.angular = angular;
        }
    }


    void Start()
    {
        Mygravity mygravity;
        for (int i = 0; i < GravityTools.Length; i++)
        {
            rigidbody_list.Add(GravityTools[i].GetComponent<Rigidbody>());
            rigidbody_list.Add(GravityBall[i].GetComponent<Rigidbody>());
        }
        for (int i = 0; i < 18;)
        {
            myData[i] = rigidbody_list[i].mass;
            myData[i+1] = rigidbody_list[i].drag;
            myData[i+2] = rigidbody_list[i].angularDrag;
            i +=3;
        }

    }

}
