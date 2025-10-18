using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    float distance = 5f;
    float jumpForce = 5f;


    [SerializeField]
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HortizontalMovement(KeyCode.A, Vector3.left);
        HortizontalMovement(KeyCode.D, Vector3.right);
    }

    void Update()
    {
        VerticalMovement(KeyCode.W, Vector3.up);

    }

    void    HortizontalMovement(KeyCode key, Vector3 direction)
    {
        if (Input.GetKey(key))
        {
            rb.MovePosition(rb.position + direction  * distance);
        }
    }

    void VerticalMovement(KeyCode key, Vector3 direction)
    {
        if (Input.GetKey(key))
        {
            rb.AddForce(direction * jumpForce);
        }
    }
}
