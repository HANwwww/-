using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject showscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] x = GameObject.FindGameObjectsWithTag("Enemy1");
        // �p�G�}�C���׬�0 �]�}�C���S�F��^
        if (x.Length == 0)
        {
            showscene.SetActive(true);
        }
    }
}
