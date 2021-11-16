using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMainManager : MonoBehaviour
{
    public static DataMainManager Instance;

    public string PlayerName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
