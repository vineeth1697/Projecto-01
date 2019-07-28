using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DataController : MonoBehaviour
{
    public Text returntext;
    public Text CopyText;
    // Start is called before the first frame update
    private string[] files;
    private string display;
    string FilePath;
    

    void Start()
    {
        returntext.text = ("Press 9 to get back to the main menu");
        //weapon.InventoryTypes.count
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            PlayerPrefs.SetInt("Exit", 9);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Menu");


        }
        if (PlayerPrefs.GetInt("Menu") == 1)
        {
            CopyText.text = getInvetoryText("Weapons.json");
        }
        else if (PlayerPrefs.GetInt("Menu") == 4)
        {
            CopyText.text = getInvetoryText("Clothing.json");
        }
        else if (PlayerPrefs.GetInt("Menu")==2)
        {
            CopyText.text = getInvetoryText("Utensils.json");
        }
        else if (PlayerPrefs.GetInt("Menu")==3)
        {
            CopyText.text = getInvetoryText("Food.json");
        }

    }


    public string getInvetoryText(string fileName)
    {
       
        FilePath = Application.dataPath + "/InventoryFile/"+fileName;
        string WeaponText = File.ReadAllText(FilePath);
        Inventory weapon = JsonUtility.FromJson<Inventory>(WeaponText);
        // CopyText.text = weapon.Name;
        foreach (InventoryTypes types in weapon.InventoryTypes)
        {
            string InventoryName = types.Name;
            int InventaryDurability = types.Durability;
            int InventoryResaleValue = types.ResaleValue;

            display = display + "Name:" + types.Name + "\nDurability:" + types.Durability + "\nResaleValue:" + types.ResaleValue + "\n\n\n";

        }
        PlayerPrefs.DeleteAll();
        return display;
    }
}
