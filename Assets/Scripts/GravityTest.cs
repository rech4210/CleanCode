using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
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

public class GravityTest : MonoBehaviour
{
    
    List<Rigidbody> rigidbody_list = new List<Rigidbody>();

    public GameObject[] GravityTools;
    public GameObject[] GravityBall;
    
    public Mygravity[] gravityfool = new Mygravity[6];

    

    void Start()
    {
        for (int i = 0; i < GravityTools.Length; i++)
        {
            rigidbody_list.Add(GravityTools[i].GetComponent<Rigidbody>());
        }

        for (int i = 0; i < GravityBall.Length; i++)
        {
            rigidbody_list.Add(GravityBall[i].GetComponent<Rigidbody>());
        }

        for (int i = 0; i < gravityfool.Length; i++)
        {
            
            Mygravity mygravity = new Mygravity();
            gravityfool[i] = mygravity;
            gravityfool[i].mass = rigidbody_list[i].mass;
            gravityfool[i].drag = rigidbody_list[i].drag;
            gravityfool[i].angular = rigidbody_list[i].angularDrag;
        }

    }
    private void Update()
    {
        for (int i = 0; i < GravityTools.Length; i++)
        {
            rigidbody_list[i].mass = gravityfool[i].mass;
            rigidbody_list[i].drag = gravityfool[i].drag;
            rigidbody_list[i].angularDrag = gravityfool[i].angular;
        }

        for (int i = 3; i < GravityBall.Length+3; i++)
        {
            rigidbody_list[i].mass = gravityfool[i].mass;
            rigidbody_list[i].drag = gravityfool[i].drag;
            rigidbody_list[i].angularDrag = gravityfool[i].angular;
        }
    }
}
