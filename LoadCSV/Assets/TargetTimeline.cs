using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TargetTimeline : MonoBehaviour
{
    public LoadExcel loadExcel;
    [Range(0.0f, 1.0f)]public float SetTime = 0.0f;
    float n = 0.0f; 
    public int i = 0; //Current array index
    [SerializeField]float CurrentTime;
    float PreTime = 0.0f;
    int MaxTime = 0;
    
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    
    void Start() {
        MaxTime = loadExcel.itemDatabase.Count;
    }
    void Update()
    {
        if (PreTime != SetTime) {
            n = MaxTime*SetTime;
            i = Mathf.RoundToInt(n);
            GameObject t1 = Instantiate(T1, new Vector3(loadExcel.itemDatabase[i].T1Tx, loadExcel.itemDatabase[i].T1Ty, loadExcel.itemDatabase[i].T1Tz), Quaternion.EulerRotation(loadExcel.itemDatabase[i].T1Rx, loadExcel.itemDatabase[i].T1Ry, loadExcel.itemDatabase[i].T1Rz));
            GameObject t2 = Instantiate(T2, new Vector3(loadExcel.itemDatabase[i].T2Tx, loadExcel.itemDatabase[i].T2Ty, loadExcel.itemDatabase[i].T2Tz), Quaternion.EulerRotation(loadExcel.itemDatabase[i].T2Rx, loadExcel.itemDatabase[i].T2Ry, loadExcel.itemDatabase[i].T2Rz));
            GameObject t3 = Instantiate(T3, new Vector3(loadExcel.itemDatabase[i].T3Tx, loadExcel.itemDatabase[i].T3Ty, loadExcel.itemDatabase[i].T3Tz), Quaternion.EulerRotation(loadExcel.itemDatabase[i].T3Rx, loadExcel.itemDatabase[i].T3Ry, loadExcel.itemDatabase[i].T3Rz));
            GameObject t4 = Instantiate(T4, new Vector3(loadExcel.itemDatabase[i].T4Tx, loadExcel.itemDatabase[i].T4Ty, loadExcel.itemDatabase[i].T4Tz), Quaternion.EulerRotation(loadExcel.itemDatabase[i].T4Rx, loadExcel.itemDatabase[i].T4Ry, loadExcel.itemDatabase[i].T4Rz));
            GameObject t5 = Instantiate(T5, new Vector3(loadExcel.itemDatabase[i].T5Tx, loadExcel.itemDatabase[i].T5Ty, loadExcel.itemDatabase[i].T5Tz), Quaternion.EulerRotation(loadExcel.itemDatabase[i].T5Rx, loadExcel.itemDatabase[i].T5Ry, loadExcel.itemDatabase[i].T5Rz));
            // t1.transform.Rotate(loadExcel.itemDatabase[i].T1Rx, loadExcel.itemDatabase[i].T1Ry, loadExcel.itemDatabase[i].T1Rz, Space.World);
            PreTime = SetTime;
            CurrentTime = loadExcel.itemDatabase[i].t;
        }
        
    }


}
