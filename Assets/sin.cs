using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sin : MonoBehaviour
{
    public GameObject target;
    private void OnCollisionEnter(Collision collision)
    {
        if (target == collision.gameObject)
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        transform.position += Vector3.up * 55;

    }
}
