using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealMove : MonoBehaviour
{
    [SerializeField] private float HealSpeed;
    [SerializeField] private float HealLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, HealSpeed) * Time.deltaTime);

        //enemyLifeTime秒後にオブジェクトを消す
        HealLifeTime = HealLifeTime - Time.deltaTime;
        if (HealLifeTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
