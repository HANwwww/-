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
        // 如果陣列長度為0 （陣列內沒東西）
        if (y.Length == 0)
        {
            if (objs.Length == 0)
            {
                // 切換到下一關
                SceneManager.LoadScene("end");

            }
        }
    }
}
