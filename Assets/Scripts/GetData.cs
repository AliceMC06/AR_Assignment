using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;
using TMPro;

public class GetData : MonoBehaviour
{
    public int[] years = {1950, 1975, 2000, 2025};
    public float[] temps = {9.8f, 10.2f, 10.4f, 11.5f};

    public TextMeshProUGI tempText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowData(0);
    }

    public void ShowData(int index)
    {
        if (index < 0 || index >= temps.Length)
        return;

        int year = years[index];
        float temp = temps[index];

        tempText.text = year + "\n" +temp.ToString("F1") + "*C";

        Debug.Log("Year: " + year + " Temp: " + temp);
    }


}
