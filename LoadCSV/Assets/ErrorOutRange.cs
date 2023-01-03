using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorOutRange : MonoBehaviour
{
    public int order;
    public int error = 0;
    public TargetTimeline targetTimeline;
    public GameObject LoadExcel;
    public Material m_Material;
    void Awake () {
        LoadExcel = GameObject.Find("LoadData");
        targetTimeline = LoadExcel.GetComponent<TargetTimeline>();
        order = targetTimeline.i;
        error = LoadExcel.GetComponent<LoadExcel>().itemDatabase[targetTimeline.i].T1Error;
        m_Material = GetComponent<Renderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        if ((order > (targetTimeline.i+600))||(order < (targetTimeline.i-600))) {
            Destroy(this.gameObject);
        }
        if (error == 1) {
            Color c = m_Material.color;
            c = Color.red;
            if (order != targetTimeline.i) {
                c.a = 0.05f;
            } else {
                c.a = 1.0f;
            }
            m_Material.color = c;
        } else {
            if (order != targetTimeline.i) {
                Color c = m_Material.color;
                c.a = 0.05f;
                m_Material.color = c;
            }
        }
        
    }
}

