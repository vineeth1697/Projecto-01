using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataController : MonoBehaviour
{
    public Text CopyText;
    // Start is called before the first frame update
    private string[] files;
    private string display;
    string FilePath;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        CopyText.text = getInvetoryText();

    }

    public string getInvetoryText()
    {
        FilePath = Application.dataPath + "/InventoryFile/Weapons.json";
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

        return display;
    }
}
