using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleUI : MonoBehaviour
{
    public TMP_InputField inputField;
    public string userName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        userName = inputField.text;
        NameManager.Instance.yourName = inputField.text;
        SceneManager.LoadScene(1);
    }
}
