using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Movimiento : MonoBehaviour
{

    public IngresarDatos datos;

    public GameObject jugador1;
    public GameObject jugador2;
    public GameObject jugador3;
    public GameObject jugador4;
    public GameObject jugador5;



    //movimiento de personajes 2d
    public float velocidad = 1;

    public Rigidbody2D rb;
    private Vector2 movimiento;
    bool rotacionz = false;

  

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        datos = FindObjectOfType<IngresarDatos>();
        
    
        
        
    }

    void Update()
    {

         if (rb.position.x < ( datos.tejecucion1[0] * 2))
        {
           jugador1.SetActive(true);
        jugador2.SetActive(false);
        jugador3.SetActive(false);
        jugador4.SetActive(false);
        jugador5.SetActive(false);
        

        jugador2.transform.position = new Vector2((datos.tejecucion1[0] *2), 2.5f);
        jugador3.transform.position = new Vector2(((datos.tejecucion1[0] + datos.tejecucion1[1]) *2), 1);
        jugador4.transform.position = new Vector2(((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2]) *2), -0.4f);
        jugador5.transform.position = new Vector2(((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2]+ datos.tejecucion1[3]) *2), -1.8f);

       
    
           
        } else if(rb.position.x < ((datos.tejecucion1[0] + datos.tejecucion1[1]) * 2))
        {
            jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(false);
        jugador4.SetActive(false);
        jugador5.SetActive(false);

         


        } else if(rb.position.x < ((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2]) * 2))
        {
            jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(false);
        jugador5.SetActive(false);

       
        } else if(rb.position.x < ((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2] + datos.tejecucion1[3]) * 2))
        {
            jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(true);
        jugador5.SetActive(false);

        
        } else if(rb.position.x < ((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2] + datos.tejecucion1[3] + datos.tejecucion1[4]) * 2))
        {
            jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(true);
        jugador5.SetActive(true);
        
        } 
            
        
        
        movimiento.x = 1f;

        
             if ( rotacionz == false)
        {
            movimiento.y += .1f;
            if (movimiento.y == .1f)
            {
                rotacionz = true;
            }
           
        }else if (rotacionz == true)
        {
            movimiento.y -= .1f;

            if (movimiento.y == -.1f)
            {
                rotacionz = false;
            }
        }
        
    

   
       


       

        if (rb.position.x > ((datos.tejecucion1[0] + datos.tejecucion1[1] + datos.tejecucion1[2] + datos.tejecucion1[3] + datos.tejecucion1[4]) * 2))
        {
            movimiento.x = 0f;
            movimiento.y = 0f;
           
        }

       
        

        

      
        
        
      
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }



    public void reset(){
        jugador1.transform.position = new Vector2(0, 1.6f);
        jugador2.transform.position = new Vector2(0, 1.6f);
        jugador3.transform.position = new Vector2(0, 0);
        jugador4.transform.position = new Vector2(0, -1.6f);
        jugador5.transform.position = new Vector2(0, -3.2f);
        rb.transform.position = new Vector2(0, 0);


    }
}