using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusHandler : MonoBehaviour
{
    public Flowchart flowChart;
    public static FungusHandler instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    public void ExecuteBlock(string Block)
    {
        flowChart.ExecuteBlock(Block);
    }


}
