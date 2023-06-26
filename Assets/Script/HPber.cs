using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPber : MonoBehaviour
{
    int maxHp = 10;
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
        //Enemyタグを設定しているオブジェクトに接触したとき
        if (collider.gameObject.tag == "enemy")
        {
            //HPから1を引く
            Hp = Hp - 1;

            //HPをSliderに反映。
            slider.value = (float)Hp / (float)maxHp; ;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
