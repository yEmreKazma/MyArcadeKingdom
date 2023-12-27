using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 50f;
    public void StartChase(Transform target)
    {
        StartCoroutine(Chase(target));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    IEnumerator Chase(Transform target)
    {
        while (true)
        {
            if(target == null)
            {
                  Destroy(gameObject);
                yield break;
  
            }
            Vector3 direction = target.position - transform.position;
            transform.up = direction;
            transform.position += direction.normalized * speed * Time.deltaTime; //normalized.
            yield return null;
        }
    }

}
