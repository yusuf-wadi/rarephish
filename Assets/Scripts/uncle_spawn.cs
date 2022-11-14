using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using System;
using System.Linq;
public class uncle_spawn : MonoBehaviour
{
    public GameObject uncle;
    public Tilemap tilemap;
    public Text gold;
    Stack<Vector3Int> shores = new Stack<Vector3Int>();
    // Start is called before the first frame update
    void Start()
    {

        for(int i=tilemap.origin.y; i < tilemap.origin.y + tilemap.size.y; i++){

            for(int j=tilemap.origin.x; j < tilemap.origin.x + tilemap.size.x; j++){
                Vector3Int cellpos = new Vector3Int(j,i,0);
                Sprite check = tilemap.GetSprite(cellpos);
                if(check == null){
                    continue;
                }
                Debug.Log(check);
                if(check.name == "cave0_7"){
                    shores.Push(cellpos);
                }
            }

        }

       
        Vector3Int spawn = shores.Pop();
        Instantiate(uncle, spawn , Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetUncle(){
        Int32 count_gold = 0; 
        Int32.TryParse(gold.text, out count_gold);

        if(count_gold >= 100){

            count_gold -= 100;
            gold.text = count_gold.ToString();
            Vector3Int spawn = shores.Pop();
            Instantiate(uncle, spawn , Quaternion.identity);
        }
        
    }
}
