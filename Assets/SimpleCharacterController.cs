using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{    
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotationSpeed = 80;

    private Rigidbody _body;
        
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        _body.position += transform.forward * moveY * moveSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, rotationSpeed * moveX * Time.deltaTime);
    }
}
