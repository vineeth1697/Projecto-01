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
    void Start()
    {
        string FilePath = Application.dataPath + "/InventoryFile/Weapons.json";

        string WeaponText=File.ReadAllText(FilePath);
        Inventory weapon = JsonUtility.FromJson<Inventory>(WeaponText);
       // CopyText.text = weapon.Name;

        foreach(InventoryTypes types in weapon.InventoryTypes)
        {
           string InventoryName= types.Name;
            int InventaryDurability = types.Durability;
            int InventoryResaleValue = types.ResaleValue;

            CopyText.text = "Name:" + types.Name + "\n Durability:" + types.Durability + "\n ResaleValue:" + types.ResaleValue;
                
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }
}
