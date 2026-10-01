using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPT : MonoBehaviour
{
    public string [] jugadas = {"Piedra", "Papel", "Tijera"};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.R))
        {
            CheckResults ("Roca");
        }
        else if (Input.GetKeyDown (KeyCode.P))
        {
            CheckResults ("Papel");
        }
        else if (Input.GetKeyDown (KeyCode.T))
        {
            CheckResults ("Tijera");

        }
    }

    void CheckResults (string jugada)
    {
        string jugadaContrincante = jugadas [Random.Range (0,3)];
        Debug.Log ("Jugaste " + jugada + "El rival jugó  " + jugadaContrincante);
        if (jugada == "Roca")
        {
            if (jugadaContrincante == "Roca")
            {
                Debug.Log ("empate");
            }
        }
        {
            if (jugadaContrincante == "Papel")
            {
                Debug.Log ("ganaste");
            }
        }
        {
            if (jugadaContrincante == "Tijera")
            {
                Debug.Log ("perdiste");
            }
        }
        if (jugada == "Papel")
        {
            if (jugadaContrincante == "Roca")
            {
                Debug.Log ("ganaste");
            }
        }
        {
            if (jugadaContrincante == "Papel")
            {
                Debug.Log ("empate");
            }
        }
        {
            if (jugadaContrincante == "Tijera")
            {
                Debug.Log ("perdiste");
            }
        }
        if (jugada == "Tijera")
        {
            if (jugadaContrincante == "Roca")
            {
                Debug.Log ("perdiste");
            }
        }
        {
            if (jugadaContrincante == "Papel")
            {
                Debug.Log ("ganaste");
            }
        }
        {
            if (jugadaContrincante == "Tijera")
            {
                Debug.Log ("empate");
            }
        }
    }
}
