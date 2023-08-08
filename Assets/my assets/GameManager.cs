using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameManager instance;
    // Start is called before the first frame update
    public static GameManager Instance(GameManager instance) { return instance; }
    public int score(int a)
    {
        a = a++; return a;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
