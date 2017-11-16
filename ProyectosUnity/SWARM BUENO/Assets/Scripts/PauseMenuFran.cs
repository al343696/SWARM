using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenuFran : MonoBehaviour {
    public Transform menu;


    public void Pause()
    {
        if (menu.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
          
        }
        else
        {
            Time.timeScale = 1;
            menu.gameObject.SetActive(false);
           
        }
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();          
        }
	}
}
