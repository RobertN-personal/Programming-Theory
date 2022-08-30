using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resourceCounter;
    [SerializeField] private Button returnToMenu;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        resourceCounter.text = "Wood: " + MainManager.Instance.woodQuantity + "\n" + "Rock: " + MainManager.Instance.rockQuantity;
    }
}
