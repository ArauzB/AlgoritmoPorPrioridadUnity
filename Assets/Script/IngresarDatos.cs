using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngresarDatos : MonoBehaviour
{

    public Rigidbody2D texto;
    public Rigidbody2D barras;



    public GameObject casilla1;
    public GameObject casilla2;
    public GameObject casilla3;
    public GameObject casilla4;
    public GameObject casilla5;

    public GameObject jugador1;
    public GameObject jugador2;
    public GameObject jugador3;
    public GameObject jugador4;
    public GameObject jugador5;

    public GameObject barra1;
    public GameObject barra2;
    public GameObject barra3;
    public GameObject barra4;
    public GameObject barra5;

    public TMP_Text[] txtjugadores = new TMP_Text[5];

    public TMP_Text[] txtProcesos = new TMP_Text[5];//
    public TMP_Text[] txtTiempoLlegada = new TMP_Text[5];//
    public TMP_Text[] txtTiempoSalida = new TMP_Text[5];
    public TMP_Text[] txtTiempoEjecucion = new TMP_Text[5];//
    public TMP_Text[] txtServicioT = new TMP_Text[5];
    public TMP_Text[] txtEsperaE = new TMP_Text[5];
    public TMP_Text[] txtIndiceI = new TMP_Text[5];
    public TMP_Text[] txtPrioridad = new TMP_Text[5];//
    public TMP_Text txtEsperaEMedia;
    public TMP_Text txtIndiceIMedia;
    public TMP_Text contador;
    public TMP_Text contador2;
    public int contador1;

    public int[] tllegada1 = new int[5];
    public int[] tejecucion1 = new int[5];
    public int[] prioridad1 = new int[5];
    public string[] alfabeto = new string[] { "A", "B", "C", "D", "E" };

    int total = 0;


    

    

    void Start()
    {
    contador1 = 1;
    }
    

    void Update()
    {
        
    if (contador1 == 1)
    {
        
        casilla1.SetActive(true);
        casilla2.SetActive(false);
        casilla3.SetActive(false);
        casilla4.SetActive(false);
        casilla5.SetActive(false);

    
        jugador1.SetActive(true);
        jugador2.SetActive(false);
        jugador3.SetActive(false);
        jugador4.SetActive(false);
        jugador5.SetActive(false);

        barra1.SetActive(true);
        barra2.SetActive(false);
        barra3.SetActive(false);
        barra4.SetActive(false);
        barra5.SetActive(false);


        

    }

    if (contador1 == 2)
    {
        
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(false);
        casilla4.SetActive(false);
        casilla5.SetActive(false);

        jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(false);
        jugador4.SetActive(false);
        jugador5.SetActive(false);

        barra1.SetActive(true);
        barra2.SetActive(true);
        barra3.SetActive(false);
        barra4.SetActive(false);
        barra5.SetActive(false);


       
    }

    if (contador1 == 3)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(false);
        casilla5.SetActive(false);

        
        jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(false);
        jugador5.SetActive(false);

        barra1.SetActive(true);
        barra2.SetActive(true);
        barra3.SetActive(true);
        barra4.SetActive(false);
        barra5.SetActive(false);


        
    }

    if (contador1 == 4)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(true);
        casilla5.SetActive(false);

        
        jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(true);
        jugador5.SetActive(false);

        barra1.SetActive(true);
        barra2.SetActive(true);
        barra3.SetActive(true);
        barra4.SetActive(true);
        barra5.SetActive(false);

    }

    if (contador1 == 5)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(true);
        casilla5.SetActive(true);

        jugador1.SetActive(true);
        jugador2.SetActive(true);
        jugador3.SetActive(true);
        jugador4.SetActive(true);
        jugador5.SetActive(true);

        barra1.SetActive(true);
        barra2.SetActive(true);
        barra3.SetActive(true);
        barra4.SetActive(true);
        barra5.SetActive(true);

        
    }



}



public void Sumar()
{
    if (contador1 < 5)
    {
        contador1++;
        contador.text = contador1.ToString();
    }

}

public void Restar()
{
    if (contador1 > 1)
    {
        contador1--;
        contador.text = contador1.ToString();
    }

}


    
//tiempo de llegada de los procesos

    public void llegada1(string tllegada)
    {
    tllegada1[0] = int.Parse(tllegada);
    //Debug.Log(tllegada1[0]);
    }
    public void llegada2(string tllegada)
    {
    tllegada1[1] =  int.Parse(tllegada);
    //Debug.Log(tllegada1[1]);
    }

    public void llegada3(string tllegada)
    {
    tllegada1[2] =  int.Parse(tllegada);
   // Debug.Log(tllegada1[2]);
    }

    public void llegada4(string tllegada)
    {
    tllegada1[3] =  int.Parse(tllegada);
    //Debug.Log(tllegada1[3]);
    }

    public void llegada5(string tllegada)
    {
    tllegada1[4] =  int.Parse(tllegada);
    //Debug.Log(tllegada1[4]);
    }



//Tiempo de ejecucion de los procesos



    public void ejecucion1(string tejecucion)
    {
    tejecucion1[0] =  int.Parse(tejecucion);
    //Debug.Log(tejecucion1[0]);
    }
    public void ejecucion2(string tejecucion)
    {
    tejecucion1[1] = int.Parse(tejecucion);
    //Debug.Log(tejecucion1[1]);
    }

    public void ejecucion3(string tejecucion)
    {
    tejecucion1[2] = int.Parse(tejecucion);
    //Debug.Log(tejecucion1[2]);
    }

    public void ejecucion4(string tejecucion)
    {
    tejecucion1[3] = int.Parse(tejecucion);
    //Debug.Log(tejecucion1[3]);
    }

    public void ejecucion5(string tejecucion)
    {
    tejecucion1[4] = int.Parse(tejecucion);
    //Debug.Log(tejecucion1[4]);
    }


//prioridad de los procesos


    public void prioridad01(string prioridad)
    {
    prioridad1[0] = int.Parse(prioridad);
    //Debug.Log(prioridad1[0]);
    }
    public void prioridad02(string prioridad)
    {
    prioridad1[1] = int.Parse(prioridad);
    //Debug.Log(prioridad1[1]);
    }

    public void prioridad03(string prioridad)
    {
    prioridad1[2] = int.Parse(prioridad);
    //Debug.Log(prioridad1[2]);
    }

    public void prioridad04(string prioridad)
    {
    prioridad1[3] = int.Parse(prioridad);
    //Debug.Log(prioridad1[3]);
    }

    public void prioridad05(string prioridad)
    {
    prioridad1[4] = int.Parse(prioridad);
   // Debug.Log(prioridad1[4]);
    }

    //alfabeto
     public void alfabeto1(string alfabeto01)
    {
    alfabeto01 = alfabeto[0];
    //Debug.Log(prioridad1[0]);
    }
    public void alfabeto2(string alfabeto01)
    {
    alfabeto01 = alfabeto[1];
    //Debug.Log(prioridad1[1]);
    }

    public void alfabeto3(string alfabeto01)
    {
    alfabeto01 = alfabeto[2];
    //Debug.Log(prioridad1[2]);
    }

    public void alfabeto4(string alfabeto01)
    {
    alfabeto01 = alfabeto[3];
    //Debug.Log(prioridad1[3]);
    }

    public void alfabeto5(string alfabeto01)
    {
    alfabeto01 = alfabeto[4];
   // Debug.Log(prioridad1[4]);
    }

    





public void ordenar(){


int auxiliar;
int auxiliar2;
int auxiliar3;
string auxiliar4;



for (int i = 1; i < contador1; i++)
{
    auxiliar = tllegada1[i];
    auxiliar2 = tejecucion1[i];
    auxiliar3 = prioridad1[i];
    auxiliar4 = alfabeto[i];

    for (int j = i - 1; j >= 0 && prioridad1[j] < auxiliar3; j--)
    {
        alfabeto[j + 1] = alfabeto[j];
        prioridad1[j + 1] = prioridad1[j];
        tllegada1[j + 1] = tllegada1[j];
        tejecucion1[j + 1] = tejecucion1[j];

        tllegada1[j] = auxiliar;
        tejecucion1[j] = auxiliar2;
        prioridad1[j] = auxiliar3;
        alfabeto[j] = auxiliar4;
    }
}

for (int i = 1; i < contador1 ; i++)
{
    auxiliar = tllegada1[i];
    auxiliar2 = tejecucion1[i];
    auxiliar3 = prioridad1[i];
    auxiliar4 = alfabeto[i];

    for (int j = i - 1; j >= 0 && tllegada1[j] > auxiliar; j--)
    {
        alfabeto[j + 1] = alfabeto[j];
        prioridad1[j + 1] = prioridad1[j];
        tllegada1[j + 1] = tllegada1[j];
        tejecucion1[j + 1] = tejecucion1[j];

        tllegada1[j] = auxiliar;
        tejecucion1[j] = auxiliar2;
        prioridad1[j] = auxiliar3;
        alfabeto[j] = auxiliar4;
    }
}

for (int i = 0; i <contador1; i++)
{
    Debug.Log(alfabeto[i] + " " + tllegada1[i] + " " + tejecucion1[i] + " " + prioridad1[i]);
    
}

for (int i = 0; i < contador1; i++)
{
    txtjugadores[i].text = alfabeto[i];
    txtProcesos[i].text = alfabeto[i];
    txtTiempoLlegada[i].text = tllegada1[i].ToString();
    txtTiempoEjecucion[i].text = tejecucion1[i].ToString();
    txtPrioridad[i].text = prioridad1[i].ToString();
   



}

int[] tiempoSalida = new int[5] {0,0,0,0,0};

tiempoSalida[0] = tllegada1[0] + tejecucion1[0];
tiempoSalida[1] = tiempoSalida[0] + tejecucion1[1];
tiempoSalida[2] = tiempoSalida[1] + tejecucion1[2];
tiempoSalida[3] = tiempoSalida[2] + tejecucion1[3];
tiempoSalida[4] = tiempoSalida[3] + tejecucion1[4];

float[] IndiceI = new float[5] {0,0,0,0,0};

for (int i = 0; i < contador1; i++)
{
    IndiceI[i] =(float)tejecucion1[i] / (tiempoSalida[i] - tllegada1[i]) ;
    txtIndiceI[i].text = IndiceI[i].ToString();
}




for (int i = 0; i < contador1; i++)
{
    txtTiempoSalida[i].text = tiempoSalida[i].ToString();
    txtServicioT[i].text = (tiempoSalida[i] - tllegada1[i]).ToString();
    txtEsperaE[i].text = (tiempoSalida[i] - tllegada1[i] - tejecucion1[i]).ToString();

}


float EsperaPromedio = 0;
float IndicePromedio = 0;

for (int i = 0; i < contador1; i++ ){

    EsperaPromedio = EsperaPromedio + (tiempoSalida[i] - tllegada1[i] - tejecucion1[i]);
    IndicePromedio = IndicePromedio + IndiceI[i];
}

txtEsperaEMedia.text = (EsperaPromedio / contador1).ToString();
txtIndiceIMedia.text = (IndicePromedio / contador1).ToString();







total = tllegada1[0];

       for (int i = 0; i < 5; i++)
        {
            total = total +  tejecucion1[i];
        }
Debug.Log(total);
        for(int i = 0; i <= total; i++)
        {   
        float x = i * 2;
        Rigidbody2D textoClone = Instantiate(texto, new Vector2(x , 4.5f), Quaternion.identity);
        Rigidbody2D barrasClone = Instantiate(barras, new Vector2(x , 0.15f), Quaternion.identity);
        textoClone.GetComponent<TMP_Text>().text = (tllegada1[0] + i).ToString();

        }


    
}



}
