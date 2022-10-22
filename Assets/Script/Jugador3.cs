using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador3 : MonoBehaviour
{
    public IngresarDatos datos;



    //movimiento de personajes 2d
    public float velocidad = 5f;

    public Rigidbody2D rb;
    private Vector2 movimiento;
    private Vector3 rotacion;
    bool rotacionz = false;
   
  

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        datos = FindObjectOfType<IngresarDatos>();
        

        
        
    }

    void Update()
    {
        
        movimiento.x = 1f;
        
           if(movimiento.x == 1f){
     if ( rotacionz == false)
        {
            rotacion.z += 1;
            if (rotacion.z == 20)
            {
                rotacionz = true;
            }
           
        }else if (rotacionz == true)
        {
            rotacion.z -= 1;

            if (rotacion.z == -20)
            {
                rotacionz = false;
            }
        }
        

}
        
    

        transform.Rotate(rotacion * Time.deltaTime * velocidad);
       


        if (rb.position.x > ((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2]) * 2))
        {
            movimiento.x = 0f;
            rotacion.z = 0;
        }
        
        
        
      
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
