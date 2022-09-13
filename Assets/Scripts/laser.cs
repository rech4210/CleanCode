using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    /*레이저 속성값 */
    public float maxDistance = 50f;
    public float duration = 0.1f;
    public Color mycolor = Color.red;
    RaycastHit hit;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.DrawRay(transform.position, transform.forward* 50f, mycolor, duration);
            

            if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
            {
                hit.transform.position = GetComponent<Transform>().RandomPosition(hit.transform.position);
            }
        }
        
    }
}
