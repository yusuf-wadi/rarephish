using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class util : MonoBehaviour
{
    // Start is called before the first frame update
    public unc_manager uncle_manager;
    public fish_costs fishcosts;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //resetting some scriptables
    private void OnDestroy() {
        
        uncle_manager.uncle_count = 0;
        fishcosts.costs.Clear();

    }

}
