using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text t;
    public string currentTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time.ToString();
        t.text = currentTime;
    }
}
