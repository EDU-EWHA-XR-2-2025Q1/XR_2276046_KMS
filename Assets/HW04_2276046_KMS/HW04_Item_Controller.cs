using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW04_Item_Controller : MonoBehaviour
{
    public GameObject UI;   
    private void OnMouseDown()
    {
        PrintInfo();                 
        UI.GetComponent<HW04_UI_Controller>().Increase_PickCounts();
        Destroy(gameObject);
    }
    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
    }
}
