using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class fisher : MonoBehaviour
{
    public fish_costs fishcosts;
    public Text fish_text;
    public GameObject fish;
    public GameObject fishyspot;
    public Image[] fishygrid;
    public unc_manager uncler;
    public Text gold;
    int uncles; 
    GameObject newFish;
    int totalFish = 0;
    int totalGold = 0;
    float timer;

    List<Vector3> fish_spawnUI;
    private void Start() {
        // change fish spawn locations according to grid, place in update function
        //fish_spawnUI = fishyspot.transform.position;
        fishygrid = fishyspot.GetComponentsInChildren<Image>();
        
        foreach(Image img_cell in fishygrid){
            Vector3 spawn = img_cell.transform.position;

            fish_spawnUI.Add(spawn);
        }

    }
    
    private void Update() {
        uncles = uncler.uncle_count;
        timer += Time.deltaTime;

        if(uncles > fishygrid.Length){
            Vector3 ns = new Vector3(fishygrid[-1].transform.position.x + fishygrid[-1].transform.localScale/2)
        }

        if(timer >= 5f) {
            IncremFish(uncles);
            timer -= 5f;
            //Destroy(newFish);   
        }
        
    
    }

    public void IncremFish(int uncles){
        Debug.Log(uncles);
        Int32.TryParse(fish_text.text, out totalFish);
        totalFish+=uncles;
        //possible bug with ind mismatch between fishspawn and uncles
        for(int i=0; i < uncles; i++){
            Instantiate(fish, fish_spawnUI[i], Quaternion.identity, GameObject.FindGameObjectWithTag("fishyspot").transform);
            //Destroy(newFish);
        }
        fish_text.text = totalFish.ToString();
    

    }

    public void SellFish(){

        Int32.TryParse(gold.text, out totalGold);
        
        for(int i = 0; i < fishcosts.costs.Count; i++){
            totalGold += fishcosts.costs[i];
        }
        gold.text = totalGold.ToString();
        Debug.Log(totalGold);
        fishcosts.costs.Clear();
        int clearfish = 0;
        fish_text.text = clearfish.ToString();


    }

}
