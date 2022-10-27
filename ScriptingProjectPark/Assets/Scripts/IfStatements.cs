using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
        
    }

    void TemperatureTest ()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature
        if(coffeeTemperature > hotlimitTemperature)
        {
            // ... do this
            print("Coffee is too hot");
        }

        // If it isn't, but the coffee temperature is less than the coldest drinking temperature
        else if(coffeeTemperature < coldlimitTemperature)
        {
            // ... do this
            print("Coffe is too cold");
        }

        //If it is neither of those then...
        else
        {
            //do this 
            print("Coffee is just right");
        }
    }

        
}
