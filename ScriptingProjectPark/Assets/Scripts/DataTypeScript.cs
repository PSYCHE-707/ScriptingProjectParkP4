using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(10, 8, 9);

        Transform tran = transform;
        tran.position = new Vector3(-20, 15, 9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
