using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Kinetic_Sculpture : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        

        float x = Mathf.Sin(Time.time);
        transform.rotation = Quaternion.Euler(new Vector3(x * 30f, x * 60f, x * 70f));

        float wave = Mathf.Sin(Time.time + (transform.position.x + transform.position.z) * 0.5f);

        transform.localScale = Vector3.one * (1f + wave * 0.4f);


    }
}