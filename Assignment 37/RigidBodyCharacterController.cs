using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment37
{

    public class RigidBodyCharacterController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float jumpForce = 5f;
        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            MoveCharacter();
        }

        void MoveCharacter()
        {
            float moveX = Input.GetAxis("Horizontal") * moveSpeed;
            float moveZ = Input.GetAxis("Vertical") * moveSpeed;
            Vector3 movement = new Vector3(moveX, 0, moveZ);

            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

            if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}