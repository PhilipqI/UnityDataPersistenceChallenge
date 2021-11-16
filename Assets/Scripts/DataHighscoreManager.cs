using System.IO;
using UnityEngine;

public class DataHighscoreManager : MonoBehaviour
{
    public static DataHighscoreManager Instance;

    public int Highscore;
    public string PlayerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class PlayerHighscoreData
    {
        public string PlayerName;
        public int Score;
    }

    public void SavePlayerHighscore(string name, int score)
    {
        PlayerHighscoreData data = new PlayerHighscoreData();
        data.Score = score;
        data.PlayerName = name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerHighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerHighscoreData data = JsonUtility.FromJson<PlayerHighscoreData>(json);

            PlayerName = data.PlayerName;
            Highscore = data.Score;
        }
    }
}
