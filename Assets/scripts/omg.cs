using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omg : MonoBehaviour
{
    public float moveSpeed = 7.0f;
    public Transform camara;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = camara.forward;
        Vector3 right = camara.right;

        // Ajustar y a 0 para no movernos verticalmente
        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * moveZ + right * moveX);

        // Mostrar informaci�n en la consola
        Debug.Log($"Movimiento: X = {moveX}, Z = {moveZ}, Direcci�n = {moveDirection}");

        // Aplicar movimiento
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }
}
