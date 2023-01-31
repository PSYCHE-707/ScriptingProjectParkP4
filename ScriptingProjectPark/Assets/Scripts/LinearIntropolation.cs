using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //In this case, result = 4
    //Mathf.Lerp takes 3 float parameters: one to represent the value to intropolate from, another to represent to intropolate to, and a float to represent how far to intropolate
  
    /* Vector 3 is another Mathf.Lerp function but with different values
     * Vector3 from = new Vector3 (1f, 2f, 3f);
     * Vector3 to = new Vector3.Lerp (from, to, 0.75f);
     * 
     * Here result = (4, 5, 6)
     * Vector3 result = Vector3.Lerp (from, to, 0.75f);
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*the intensity of the light willl start off at 0 and tend towards 8 over several frames, the rate of its change will slow as it gets closer to its target
         * light.intensity = Math.Lerp(light.intensity, 8f, 0.5f);
         * 
         * This changes the intensity from per frame to per second
         * light.intensity = Math.Lerp(light.intensity, 8f, o.5f * Time.deltaTime);
         * */
    }
}
