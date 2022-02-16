using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.y);
        /*if (transform.position.y <= 3f)
        {
            Debug.Log("i'm about to hit the ground!");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 3f)
        {
            print("i'm about to hit the ground!");
        }
    }
}
