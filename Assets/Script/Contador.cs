using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Contador : MonoBehaviour
{
private IngresarDatos ingreso;
public GameObject casilla1;
public GameObject casilla2;
public GameObject casilla3;
public GameObject casilla4;
public GameObject casilla5;

public TMP_Text contador;
public int contador1;

void Start()
{
contador1 = 1;
}
void Update()
{
    if (contador1 == 1)
    {
        
        casilla1.SetActive(true);
       // casilla2.SetActive(false);
       // casilla3.SetActive(false);
       // casilla4.SetActive(false);
       // casilla5.SetActive(false);
    }
    if (contador1 == 2)
    {
        
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(false);
        casilla4.SetActive(false);
        casilla5.SetActive(false);
    }
    if (contador1 == 3)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(false);
        casilla5.SetActive(false);
    }
    if (contador1 == 4)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(true);
        casilla5.SetActive(false);
    }
    if (contador1 == 5)
    {
        casilla1.SetActive(true);
        casilla2.SetActive(true);
        casilla3.SetActive(true);
        casilla4.SetActive(true);
        casilla5.SetActive(true);
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

}


