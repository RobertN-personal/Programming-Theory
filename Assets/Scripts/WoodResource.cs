using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodResource : Resource
{   // INHERITANCE
    [SerializeField] int woodValue = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // POLYMORPHISM
    public override void CollectResource()
    {
        MainManager.Instance.woodQuantity += woodValue;
        isReady = false;
        StartCoroutine(CollectableResource());
    }
}
