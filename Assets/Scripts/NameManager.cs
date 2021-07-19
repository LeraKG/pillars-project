using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance { get; private set; }

    public string yourName;
    public TMP_InputField inputField;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
