using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Assignment_20
{
    public class Toy : MonoBehaviour
    {

        void Start()
        {

        }


        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0.01f, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-0.01f, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 0.01f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -0.01f);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation = quaternion.Euler(new Vector3(0, 90, 0));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
    }
}