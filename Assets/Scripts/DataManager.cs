using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string actualPlayerName;
    public int actualScore;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(Instance);
    }
    [System.Serializable]
    class SaveData : DataManager
    {
        public string bestPlayer;
        public int bestScore;
    }
    
    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.bestPlayer = actualPlayerName;
        data.bestScore = actualScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/savefile.json");
        SaveData data = JsonUtility.FromJson<SaveData>(json);
    }
}
