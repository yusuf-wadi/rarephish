using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fish_gen : MonoBehaviour
{
    float timer;
    public fish_costs fishcosts;
    public class rarities
    {
        public Hashtable values = new Hashtable();

        //each int refers to a percent% chance of that rarirty occurring. must add to 100
        public rarities(
            int common,
            int uncommon,
            int rare,
            int epic,
            int legenedary,
            int granularity
        )
        {
            for (int i = 0; i < common; i++)
            {
                this.values.Add(i, "common");
            }
            for (int i = common; i < common + uncommon; i++)
            {
                this.values.Add(i, "uncommon");
            }
            for (int i = common + uncommon; i < common + uncommon + rare; i++)
            {
                this.values.Add(i, "rare");
            }
            for (int i = common + uncommon + rare; i < common + uncommon + rare + epic; i++)
            {
                this.values.Add(i, "epic");
            }
            for (int i = common + uncommon + rare + epic; i < granularity; i++)
            {
                this.values.Add(i, "legendary");
            }
        }
    }

    [System.Serializable]
    class Parts
    {
        public Sprite[] array;

        public Parts(Sprite[] Array)
        {
            array = Array;
        }
    }

    [SerializeField]
    Parts[] frills,
        bodies,
        fins,
        tails =
            new Parts[]
            {
                new Parts(new Sprite[0]),
                new Parts(new Sprite[0]),
                new Parts(new Sprite[0]),
                new Parts(new Sprite[0]),
                new Parts(new Sprite[0])
            };

    static rarities rarity_vals = new rarities(400, 300, 200, 95, 5, 1000);
    Hashtable rar2arr = new Hashtable
    {
        { "common", 4 },
        { "uncommon", 3 },
        { "rare", 2 },
        { "epic", 1 },
        { "legendary", 0 }
    };

    Image[] part_img;

    void Start()
    {
        //part_img = gameObject.GetComponentsInChildren<SpriteRenderer>();
        part_img = gameObject.GetComponentsInChildren<Image>();
        spawnFish();
    }

    void Update(){
        timer += Time.deltaTime;

        if(timer >= 1f) {
            timer -= 1f;
            Destroy(this.gameObject);   
        }
        
    }

    void spawnFish()
    {
        string frill_rar = "",
            body_rar = "",
            fin_rar = "",
            tail_rar = "";
        foreach (Image spriterend in part_img)
        {
            string ob_name = spriterend.gameObject.name;
            Debug.Log(ob_name);

            //switch case to check for each name and use the associated array to affect the associated sprite rend

            switch (ob_name)
            {
                case "frill":
                    int chance = Random.Range(0, 1000);
                    frill_rar = rarity_vals.values[chance].ToString();
                    int rarInd = (int)rar2arr[frill_rar];
                    spriterend.sprite = frills[rarInd].array[
                        Random.Range(0, frills[rarInd].array.Length)
                    ];
                    Debug.Log(frill_rar);
                    break;
                case "body":
                    int chance2 = Random.Range(0, 1000);
                    body_rar = rarity_vals.values[chance2].ToString();
                    int rarInd2 = (int)rar2arr[body_rar];
                    spriterend.sprite = bodies[rarInd2].array[
                        Random.Range(0, bodies[rarInd2].array.Length)
                    ];
                    Debug.Log(body_rar);
                    break;
                case "fin":
                    int chance3 = Random.Range(0, 1000);
                    fin_rar = rarity_vals.values[chance3].ToString();
                    int rarInd3 = (int)rar2arr[fin_rar];
                    spriterend.sprite = fins[rarInd3].array[
                        Random.Range(0, fins[rarInd3].array.Length)
                    ];
                    Debug.Log(fin_rar);
                    break;
                case "tail":
                    int chance4 = Random.Range(0, 1000);
                    tail_rar = rarity_vals.values[chance4].ToString();
                    int rarInd4 = (int)rar2arr[tail_rar];
                    spriterend.sprite = tails[rarInd4].array[
                        Random.Range(0, tails[rarInd4].array.Length)
                    ];
                    Debug.Log(tail_rar);
                    break;
                default:
                    Debug.LogError("Error: part name not found");
                    break;
            }
        }

        int fishcost = getFishCost(frill_rar, body_rar, fin_rar, tail_rar);

        Debug.Log("This is the current fish total cost: " + fishcost);

        fishcosts.costs.Add(fishcost);
    }

    int getFishCost(string frill_rar, string body_rar, string fin_rar, string tail_rar)
    {
        string[] fishrars = new string[] { frill_rar, body_rar, fin_rar, tail_rar };
        int cost = 0;
        foreach (string part in fishrars)
        {
            switch (part)
            {
                case "common":
                    cost += 3;
                    break;
                case "uncommon":
                    cost += 5;
                    break;
                case "rare":
                    cost += 9;
                    break;
                case "epic":
                    cost += 15;
                    break;
                case "legendary":
                    cost += 23;
                    break;
            }
        }

        return cost;
    }
}
