using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] public int resourceValue = 0;
    [SerializeField] public float regenerateTime = 5;
    
    //ENCAPSULATION

    public bool isReady { get; set; } = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver() 
    {
        if (isReady)
        {
            
            CollectResource();
            
        }
        
    }

    public virtual void CollectResource()
    {
        resourceValue += 5;
        isReady = false;
        StartCoroutine(CollectableResource());
    }

    public IEnumerator CollectableResource()
    {
        yield return new WaitForSeconds(regenerateTime);
        isReady = true;
    }

    
}
