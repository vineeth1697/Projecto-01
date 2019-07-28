using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DataController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
               
        string pathToFIle = Application.dataPath + "/InventoryFile/Food.json";
        string text = File.ReadAllText(pathToFIle);

         Inventory food = JsonUtility.FromJson<Inventory>(text);

        //InventoryTest food = JsonConvert.DeserializeObject<InventoryTest>(text);

        Debug.Log(text);

        Debug.Log(food.Name);

        foreach(InventoryTypes type in food.InventoryTypes)
        {
            Debug.Log(type.Name + "===" + type.Durability + "==" + type.ResaleValue);
        }




   
    }

    public class InventoryTest
    {
        public string Name { get; set; }
        List<InventoryTypes> InventoryTypes { get; set; }
        public string Image { get; set; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
