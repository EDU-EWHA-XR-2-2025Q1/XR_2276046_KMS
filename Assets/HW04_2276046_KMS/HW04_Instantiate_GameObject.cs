using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW04_Instantiate_GameObject : MonoBehaviour
{
    public GameObject Target;
    public static HW04_Instantiate_GameObject Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Instantiate_GameObject(int cloneCount)
    {
        StartCoroutine(InstantiateClones(cloneCount));
    }

    IEnumerator InstantiateClones(int cloneCount)
    {
        for (int i = 0; i < cloneCount; i++)
        {
            Vector3 randomSphere = Random.insideUnitSphere * 0.25f;
            randomSphere.y = 0.025f;
            
            GameObject Clone = Instantiate(
                Target, 
                randomSphere, 
                Quaternion.Euler(0, Random.Range(0, 360f), 0)
            );
            
            Clone.SetActive(true);
            Clone.name = "Clone-" + i.ToString("D4");
            
            DontDestroyOnLoad(Clone); 
            

            Clone.transform.SetParent(transform);
            
            yield return null; 
        }
    }
}
//     public void Instantiate_GameObject(int cloneCount)
//     {
//         for (int i = 0; i < cloneCount; i++)
//         {
//             Vector3 randomSphere = Random.insideUnitSphere * 0.25f;
//             randomSphere.y = 0.025f;
//             GameObject Clone = Instantiate(Target, randomSphere, Quaternion.Euler(0, Random.Range(0, 360f), 0));
//             Clone.SetActive(true);
//             Clone.name = "Clone-" + i.ToString("D4");
//             Clone.transform.SetParent(transform);
//         }

//     }
// }