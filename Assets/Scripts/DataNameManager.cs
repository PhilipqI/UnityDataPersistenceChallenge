using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataNameManager : MonoBehaviour
{
    public static DataNameManager Instance;

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
