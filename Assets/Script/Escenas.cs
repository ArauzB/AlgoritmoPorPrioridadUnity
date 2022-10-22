using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    public GameObject escena1;
    public GameObject escena2;
    public GameObject escena3;




    void Start()
    {
        escena1.SetActive(true);
        escena2.SetActive(false);
        escena3.SetActive(false);
        Time.timeScale = 0; 
    }


    public void CambiarEscena1()
    {
        //SceneManager.LoadScene(nombre);
        escena1.SetActive(false);
        escena2.SetActive(true);
        escena3.SetActive(false);
        Time.timeScale = 1; 
        
    }

     public void CambiarEscena2()
    {
        //SceneManager.LoadScene(nombre);
        escena1.SetActive(false);
        escena2.SetActive(false);
        escena3.SetActive(true);
        Time.timeScale = 0; 
    }

    void Update()
    {
        if (escena1.activeSelf == true)
        {
            Time.timeScale = 0; 
        }else if (escena1.activeSelf == false)
        {
            Time.timeScale = 1; 
        }
    }


     public void Play(string nombre)
    {
        SceneManager.LoadScene(nombre);
        
    }

     public void Exit()
    {
        Application.Quit();
        
    }


     public void Atras(string nombre)
    {
        SceneManager.LoadScene(nombre);
        Debug.Log("Atras");
        
    }
}
