using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha = true;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        
        rigidBody.velocity = new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);

        GestionarOrientacion(inputMovimiento);
    }

    void GestionarOrientacion(float inputMovimiento)
    {
        /*if( (mirandoDerecha = true && inputMovimiento < 0) || (mirandoDerecha = false && inputMovimiento > 0) )
        {
            // Ejecutar codigo de volteado
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }*/

        if(inputMovimiento < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(inputMovimiento > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

