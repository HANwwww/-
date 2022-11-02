using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float a = 5f;

        double b = 5f;

        float dist = Vector3.Distance(transform.position, target.position);
        if (dist < 6)
        {
            transform.localScale = new Vector3(2, 2, 3);

        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
