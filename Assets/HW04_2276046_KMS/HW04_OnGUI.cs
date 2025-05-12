using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters; 

public class HW04_OnGUI : MonoBehaviour 
{ 
    [Range(10, 150)] 
    public int fontSize = 30; 
    public Color color = new Color(.0f, .0f, .0f, 1.0f); 
    public float width, height; 
    string message; 
    public GameObject Target;      
    public int cloneCount = 10;  
    public GameObject Initiate;  

    public void OnTarget_Found(string _s) 
    { 
        message = _s; 
        print(cloneCount); 
        Initiate.GetComponent<HW04_Instantiate_GameObject>().Instantiate_GameObject(cloneCount);
        print(cloneCount); 
    } 

    public void OnTarget_Lost(string _s) 
    { 
        message = _s; 
    } 

    void OnGUI() 
    { 
        GUIStyle style = new GUIStyle(); 
        style.fontSize = fontSize; 
        style.normal.textColor = color; 
        style.alignment = TextAnchor.UpperLeft; 
        GUI.Label(new Rect(0, 0, width, height), message, style); 
    } 
} 