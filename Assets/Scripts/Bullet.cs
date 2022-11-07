using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    public float speed = 30f;
    private Rigidbody rb;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "wall")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }


}
