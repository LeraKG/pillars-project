using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Hello, " + NameManager.Instance.yourName;
    }
}
