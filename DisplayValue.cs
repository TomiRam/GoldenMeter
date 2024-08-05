using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayValue : MonoBehaviour
{
    public Slider Meter;
    public TMP_Text ValueText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ValueText.text = Meter.value.ToString();
    }
}
