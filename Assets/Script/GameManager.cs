using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image HeathBar;
    public float Hp = 100;
    public bool drowning;

    private void FixedUpdate()
    {
        Drowning();
    }

    private void Drowning()
    {
        if(drowning)
        {
            Hp -= Time.deltaTime * 5;
            HeathBar.fillAmount = Hp / 100;
        }
    }
}
