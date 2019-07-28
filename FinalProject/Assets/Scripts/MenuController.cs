using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController:MonoBehaviour 
{
    public Text MenuText;
    public static DataController dataController;
    // Start is called before the first frame update
    void Start()
    {
        MenuText.text = "1.Weapons\n2.Utilities\n3.Food \n4.Clothing";       
     }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Calling Key 1");
            PlayerPrefs.SetInt("Menu", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene("mainwindow");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("Calling Key 2");
            PlayerPrefs.SetInt("Menu", 4);
            PlayerPrefs.Save();
            SceneManager.LoadScene("mainwindow");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayerPrefs.SetInt("Menu", 2);
            PlayerPrefs.Save();
            SceneManager.LoadScene("mainwindow");
        
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
            PlayerPrefs.SetInt("Menu", 3);
            PlayerPrefs.Save();
            SceneManager.LoadScene("mainwindow");

        }

    }

}
