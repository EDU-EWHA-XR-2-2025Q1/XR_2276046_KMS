using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HW04_UI_Controller : MonoBehaviour
{
    public TMP_Text pc;
    public TMP_Text sc;
    public static int PickCounts = 0;          
    public static int PutCounts = 0;

    void Start()
    {
        Display_PickCounts();
        Display_PutCounts();
    }
    public void Increase_PickCounts(){
        PickCounts += 1;
        Display_PickCounts();
    }
    public void Display_PickCounts()
    {
        pc.text = PickCounts.ToString();
    }
    public void Increase_PutCounts(){
        PutCounts += 1;
        Display_PutCounts();
    }
    public void Display_PutCounts()
    {
        sc.text = PutCounts.ToString();
    }
    public int GetPickCounts(){
        return PickCounts;
    }
    public void Decrease_PickCounts(){
        PickCounts -= 1;
        Display_PickCounts();
    }
}
