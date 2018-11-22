using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    private int power;  //武器の力

    // Use this for initialization
    void Start () {
        //レベルを取得
        int level = GameObject.Find("GameManager(Clone)").gameObject.GetComponent<Completed.GameManager>().GetLevel();

        //武器の力の値を設定
        int min = level - 2;
        int max = min + 5;
        //弱くなり過ぎない様に調節
        if (min <= 1) min = 1;
        power = Random.Range(min, max);
	}

    public int GetPower()
    {
        return power;
    }
}
