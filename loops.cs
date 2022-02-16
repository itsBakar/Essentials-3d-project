using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{
    int enemies = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemies; i++)
        {
            print("Creating Enemie!");
        }

        bool shouldContinue = false;
        do
        {
            print("Remove Enemies");

        } while (shouldContinue == true);

        string[] enemiess = new string[5];
        enemiess[0] = "Remove Enemy 1";
        enemiess[1] = "Remove Enemy 2";
        enemiess[2] = "Remove Enemy 3";
        enemiess[3] = "Remove Enemy 4";
        enemiess[4] = "Remove Enemy 5";

        foreach (string item in enemiess)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        while (enemies > 0)
        {
            print("Removing Enemies");
            enemies--;
        }
    }
}