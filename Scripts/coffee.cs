using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffee : MonoBehaviour
{
    float coffeetemp = 85.0f;
    float coffeetemphot = 70.0f;
    float coffeetempcold = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        
            tempcheck();
            coffeetemp -= Time.deltaTime * 5f;

        
    }
    
    void tempcheck()
    {
        if (coffeetemp > coffeetemphot)
        {
            print("coffee is hot!");
        }
        else if (coffeetemp < coffeetempcold)
        {
            print("coffee is cold!");
        }
        else
        {
            print("coffee is just right!");
        }
    }
}
