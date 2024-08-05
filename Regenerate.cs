using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Regenerate : MonoBehaviour
{
    public Slider Meter;
    public TMP_Text WarningText;
    public Button UseBtn;
    public Button RecoverBtn;


    public int DrainRate = 1;
    public int RecoveryRate = 1;
   
    public bool isDraining = false;
    public bool isRegenarating = false;

    void Start()
    {
     UseBtn.onClick.AddListener(Use);
     RecoverBtn.onClick.AddListener(Recover);   
    }

    void Update()
    {
       
       if(Meter.value<30)
       {
        WarningText.text = "Warning: Meter is near 0";
        

       }
        
        if(Meter.value>30)
       {
        WarningText.text = "";
       }

       if(isDraining)
       {
        Drain();
       }
       if(isRegenarating)
       {
        Regenerating(); 
       }
    }

   
    public void Use()
    {
        if(Meter.value >=0)
        {   
              isDraining = true;
              isRegenarating = false;     
        }
      
    }
    public void Recover()
    {
        if(Meter.value >=0)
        {
            isDraining= false;
            isRegenarating = true;
        }
    }
     public void Drain()
     {
        float CurrentValue = Meter.value;
        float NewValue = CurrentValue - DrainRate*Time.deltaTime;
        Meter.value = NewValue;

     }
     public void  Regenerating()
     {
        float CurrentValue = Meter.value;
        float NewValue = CurrentValue + RecoveryRate*Time.deltaTime;
        Meter.value = NewValue;
     }
}
