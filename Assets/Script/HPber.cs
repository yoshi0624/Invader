using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPber : MonoBehaviour
{
    int maxHp = 5;
    int Hp;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        Hp = maxHp;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "enemy")
        {
            Hp = Hp - 1;
            slider.value = (float)Hp / (float)maxHp; ;

        }
        if (collider.gameObject.tag == "Heal")
        {
            Hp = Hp + 1;
            slider.value = (float)Hp / (float)maxHp; ;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
