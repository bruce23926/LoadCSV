using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutRanged : MonoBehaviour
{
    public int order;
    public TargetTimeline targetTimeline;
    public GameObject LoadExcel;
    public Material m_Material;
    void Awake () {
        LoadExcel = GameObject.Find("LoadData");
        targetTimeline = LoadExcel.GetComponent<TargetTimeline>();
        order = targetTimeline.i;
        m_Material = GetComponent<Renderer>().material;
    }
    // Update is called once per frame
    void Update()
    {
        if ((order > (targetTimeline.i+600))||(order < (targetTimeline.i-600))) {
            Destroy(this.gameObject);
        }
        if (order != targetTimeline.i) {
            Color c = m_Material.color;
            c.a = 0.05f;
            m_Material.color = c;

        }
    }
}
