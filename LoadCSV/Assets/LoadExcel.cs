using UnityEngine;
using System.Collections.Generic;
using System.Collections;

 
public class LoadExcel : MonoBehaviour
{
    public string FileName;
    public Item blankItem;
    public List<Item> itemDatabase = new List<Item>();

    public void LoadItemData() {
        itemDatabase.Clear();

        List<Dictionary<string, object>> data = CSVReader.Read(FileName);
        for (var i=0; i<data.Count; i++) {
            float t = float.Parse(data[i]["t"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Tx = float.Parse(data[i]["T1Tx"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Ty = float.Parse(data[i]["T1Ty"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Tz = float.Parse(data[i]["T1Tz"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Rx = float.Parse(data[i]["T1Rx"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Ry = float.Parse(data[i]["T1Ry"].ToString(), System.Globalization.NumberStyles.Float);
            float T1Rz = float.Parse(data[i]["T1Rz"].ToString(), System.Globalization.NumberStyles.Float);
            int T1Error = int.Parse(data[i]["T1Error"].ToString(), System.Globalization.NumberStyles.Integer);
            float T2Tx = float.Parse(data[i]["T2Tx"].ToString(), System.Globalization.NumberStyles.Float);
            float T2Ty = float.Parse(data[i]["T2Ty"].ToString(), System.Globalization.NumberStyles.Float);
            float T2Tz = float.Parse(data[i]["T2Tz"].ToString(), System.Globalization.NumberStyles.Float);
            float T2Rx = float.Parse(data[i]["T2Rx"].ToString(), System.Globalization.NumberStyles.Float);
            float T2Ry = float.Parse(data[i]["T2Ry"].ToString(), System.Globalization.NumberStyles.Float);
            float T2Rz = float.Parse(data[i]["T2Rz"].ToString(), System.Globalization.NumberStyles.Float);
            int T2Error = int.Parse(data[i]["T2Error"].ToString(), System.Globalization.NumberStyles.Integer);
            float T3Tx = float.Parse(data[i]["T3Tx"].ToString(), System.Globalization.NumberStyles.Float);
            float T3Ty = float.Parse(data[i]["T3Ty"].ToString(), System.Globalization.NumberStyles.Float);
            float T3Tz = float.Parse(data[i]["T3Tz"].ToString(), System.Globalization.NumberStyles.Float);
            float T3Rx = float.Parse(data[i]["T3Rx"].ToString(), System.Globalization.NumberStyles.Float);
            float T3Ry = float.Parse(data[i]["T3Ry"].ToString(), System.Globalization.NumberStyles.Float);
            float T3Rz = float.Parse(data[i]["T3Rz"].ToString(), System.Globalization.NumberStyles.Float);
            int T3Error = int.Parse(data[i]["T3Error"].ToString(), System.Globalization.NumberStyles.Integer);
            float T4Tx = float.Parse(data[i]["T4Tx"].ToString(), System.Globalization.NumberStyles.Float);
            float T4Ty = float.Parse(data[i]["T4Ty"].ToString(), System.Globalization.NumberStyles.Float);
            float T4Tz = float.Parse(data[i]["T4Tz"].ToString(), System.Globalization.NumberStyles.Float);
            float T4Rx = float.Parse(data[i]["T4Rx"].ToString(), System.Globalization.NumberStyles.Float);
            float T4Ry = float.Parse(data[i]["T4Ry"].ToString(), System.Globalization.NumberStyles.Float);
            float T4Rz = float.Parse(data[i]["T4Rz"].ToString(), System.Globalization.NumberStyles.Float);
            int T4Error = int.Parse(data[i]["T4Error"].ToString(), System.Globalization.NumberStyles.Integer);
            float T5Tx = float.Parse(data[i]["T5Tx"].ToString(), System.Globalization.NumberStyles.Float);
            float T5Ty = float.Parse(data[i]["T5Ty"].ToString(), System.Globalization.NumberStyles.Float);
            float T5Tz = float.Parse(data[i]["T5Tz"].ToString(), System.Globalization.NumberStyles.Float);
            float T5Rx = float.Parse(data[i]["T5Rx"].ToString(), System.Globalization.NumberStyles.Float);
            float T5Ry = float.Parse(data[i]["T5Ry"].ToString(), System.Globalization.NumberStyles.Float);
            float T5Rz = float.Parse(data[i]["T5Rz"].ToString(), System.Globalization.NumberStyles.Float);
            int T5Error = int.Parse(data[i]["T5Error"].ToString(), System.Globalization.NumberStyles.Integer);
            // string name = data[i]["name"].ToString();
            // string description = data[i]["description"].ToString();
            AddItem(t, T1Tx, T1Ty, T1Tz, T1Rx, T1Ry, T1Rz, T1Error, T2Tx, T2Ty, T2Tz, T2Rx, T2Ry, T2Rz, T2Error, T3Tx, T3Ty, T3Tz, T3Rx, T3Ry, T3Rz, T3Error, T4Tx, T4Ty, T4Tz, T4Rx, T4Ry, T4Rz, T4Error, T5Tx, T5Ty, T5Tz, T5Rx, T5Ry, T5Rz, T5Error);
        }
    }

    void AddItem(float t, float T1Tx, float T1Ty, float T1Tz, float T1Rx, float T1Ry, float T1Rz, int T1Error, float T2Tx, float T2Ty, float T2Tz, float T2Rx, float T2Ry, float T2Rz, int T2Error, float T3Tx, float T3Ty, float T3Tz, float T3Rx, float T3Ry, float T3Rz, int T3Error, float T4Tx, float T4Ty, float T4Tz, float T4Rx, float T4Ry, float T4Rz, int T4Error, float T5Tx, float T5Ty, float T5Tz, float T5Rx, float T5Ry, float T5Rz, int T5Error) {//int id, string name, string description
        Item tempItem = new Item(blankItem);

        tempItem.t = t;
        tempItem.T1Tx = T1Tx;
        tempItem.T1Ty = T1Ty;
        tempItem.T1Tz = T1Tz;
        tempItem.T1Rx = T1Rx;
        tempItem.T1Ry = T1Ry;
        tempItem.T1Rz = T1Rz;
        tempItem.T1Error = T1Error;
        tempItem.T2Tx = T2Tx;
        tempItem.T2Ty = T2Ty;
        tempItem.T2Tz = T2Tz;
        tempItem.T2Rx = T2Rx;
        tempItem.T2Ry = T2Ry;
        tempItem.T2Rz = T2Rz;
        tempItem.T2Error = T2Error;
        tempItem.T3Tx = T3Tx;
        tempItem.T3Ty = T3Ty;
        tempItem.T3Tz = T3Tz;
        tempItem.T3Rx = T3Rx;
        tempItem.T3Ry = T3Ry;
        tempItem.T3Rz = T3Rz;
        tempItem.T3Error = T3Error;
        tempItem.T4Tx = T4Tx;
        tempItem.T4Ty = T4Ty;
        tempItem.T4Tz = T4Tz;
        tempItem.T4Rx = T4Rx;
        tempItem.T4Ry = T4Ry;
        tempItem.T4Rz = T4Rz;
        tempItem.T4Error = T4Error;
        tempItem.T5Tx = T5Tx;
        tempItem.T5Ty = T5Ty;
        tempItem.T5Tz = T5Tz;
        tempItem.T5Rx = T5Rx;
        tempItem.T5Ry = T5Ry;
        tempItem.T5Rz = T5Rz;
        tempItem.T5Error = T5Error;
        
        itemDatabase.Add(tempItem);
    }
}
