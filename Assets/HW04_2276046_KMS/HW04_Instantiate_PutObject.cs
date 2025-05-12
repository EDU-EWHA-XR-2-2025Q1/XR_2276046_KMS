using System.Collections;
using UnityEngine;

public class HW04_Instantiate_PutObject : MonoBehaviour
{
    public GameObject Target;
    public GameObject UI_Controller;
    void Start()
    {
        StartCoroutine(RandomMovementRoutine());
    }

    IEnumerator RandomMovementRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
            
            Vector3 newPosition = Random.insideUnitSphere * 0.5f;
            newPosition.y = 1f;
            transform.localPosition = newPosition;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        UI_Controller.GetComponent<HW04_UI_Controller>().Decrease_PickCounts();
        Destroy(other.gameObject);
    }
}

