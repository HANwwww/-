using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene2 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("coin");
        GameObject[] y = GameObject.FindGameObjectsWithTag("enemy");
        // �p�G�}�C���׬�0 �]�}�C���S�F��^
        if (y.Length == 0)
        {
            if (objs.Length == 0)
            {
                // ������U�@��
                SceneManager.LoadScene("end");

            }
        }
    }
}
