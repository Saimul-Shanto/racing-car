using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MiliCount;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinuteSave");
        SecCount = PlayerPrefs.GetInt("SecondSave");
        MiliCount = PlayerPrefs.GetFloat("MiliSave");

        MinDisplay.GetComponent<TextMeshProUGUI>().text = ""+MinCount;
        SecDisplay.GetComponent<TextMeshProUGUI>().text ="" +SecCount;
        MiliDisplay.GetComponent<TextMeshProUGUI>().text =""+MiliCount ;
    }
    
}
