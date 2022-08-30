using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockResource : Resource
{
    [SerializeField] int rockValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CollectResource()
    {
        MainManager.Instance.rockQuantity += rockValue;
        isReady = false;
        StartCoroutine(CollectableResource());
    }
}
