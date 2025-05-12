using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HW04_Put_Controller : MonoBehaviour
{
    public GameObject TargetObjectToThrow;
    public Transform PlayerCamera;   
    public GameObject UI;
    public Button button;

    public void Update(){
        int pickCounts = UI.GetComponent<HW04_UI_Controller>().GetPickCounts();
        if (pickCounts > 0)
        {
            ColorBlock colorBlock = button.colors;
            colorBlock.normalColor = Color.red;
            button.colors = colorBlock;
        }
        else{
            ColorBlock colorBlock = button.colors;
            colorBlock.normalColor = Color.black;
            button.colors = colorBlock;
        }
    }

    void Throw()
    {
        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward;
        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);
        GameObject Clone = Instantiate(TargetObjectToThrow, Pos, randomRot);
        Clone.SetActive(true);
        Clone.GetComponent<Rigidbody>().useGravity = true;
        Clone.GetComponent<Rigidbody>().AddForce(PlayerCamera.forward * 400f);
        Destroy(Clone, 3);
    }
    public void Onclick() {
        int pickCounts = UI.GetComponent<HW04_UI_Controller>().GetPickCounts();
        if (pickCounts > 0)
        {
            Throw();
            UI.GetComponent<HW04_UI_Controller>().Decrease_PickCounts();
        }
    }
}

