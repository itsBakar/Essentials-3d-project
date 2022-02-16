using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    int num = 100;
    // Start is called before the first frame update
    void Start()
    {
        num = multiplication(num);
        Debug.Log(num);
    }

    private int multiplication(int number)
    {
        int result;
        result = number * 5;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
