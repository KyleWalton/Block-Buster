using System;
using UnityEngine;

public class DataMutator : MonoBehaviour
{
    public static DataMutator Instance { get; private set; }

    public float speed;

    public bool largeBall;

    public int ballColor;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Time.timeScale = speed;
    }
}
