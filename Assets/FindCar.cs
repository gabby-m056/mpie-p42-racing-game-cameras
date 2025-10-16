using UnityEngine;

public class FindCar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = GameObject.Find("Car");
        gameObject.transform.LookAt(target.transform);
    }
}
