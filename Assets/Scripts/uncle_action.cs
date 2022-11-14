using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uncle_action : MonoBehaviour
{
    // Start is called before the first frame update
    public unc_manager uncle_manage;
        
    void Start()
    {
        //int curruncount = uncle_manage.uncle_count;

        uncle_manage.uncle_count++;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
