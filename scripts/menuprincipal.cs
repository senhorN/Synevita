using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipal : MonoBehaviour
{
   
    public void Sair()
    {
        Debug.Log("saiu");
        Application.Quit();
    }


    public void Jogar(string cena)
    {
        SceneManager.LoadScene(cena);
    }


    
 
   
}
