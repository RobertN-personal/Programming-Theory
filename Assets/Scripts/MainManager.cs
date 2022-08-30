using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int woodQuantity;
    public int rockQuantity;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadResources();
    }

    [System.Serializable]
    class SaveData
    {
        public int woodQuantity;
        public int rockQuantity;
    }
    public void SaveResources()
    {
    SaveData data = new SaveData();
    data.woodQuantity = woodQuantity;
    data.rockQuantity = rockQuantity;

    string json = JsonUtility.ToJson(data);
  
    File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadResources()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
            {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            woodQuantity = data.woodQuantity;
            rockQuantity = data.rockQuantity;
            }
        }

    
}
