using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealMaker : MonoBehaviour
{
    [SerializeField] private GameObject HealPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float HealZ;
    [SerializeField] private float HealX;
    private float ranX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }
        else
        {
            ranX = Random.Range(HealX * -1, HealX);
            Instantiate(HealPrefab, new Vector3(ranX, 0, HealZ), HealPrefab.transform.rotation);
            waitTime = 0;
        }
    }
}
