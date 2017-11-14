using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenuFran : MonoBehaviour {
    public Transform menu;
    //coger el controlador del jugador para parar el movimiento

    public void Pause()
    {
        if (menu.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
            //Falta bloquear el movimiento del jugador
        }
        else
        {
            Time.timeScale = 1;
            menu.gameObject.SetActive(false);
            //Y aqui reactivar el movimiento otra vez
        }
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();          
        }
	}
}
