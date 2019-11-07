using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("對話")]
    public string Say = "走開!!!!!!!!";
    public float SaySpeed = 1f;
    [Header("任務")]
    public bool Complete = false;
    public int BateryFinish = 10;
    public int Batery = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
