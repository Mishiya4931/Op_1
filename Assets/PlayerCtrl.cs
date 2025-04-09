using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] private float JumpDecPow = 0.0f;
    public float JumpPower;//ポジションに加える変数
    // Start is called before the first frame update
    void Start()
    {
        JumpPower = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //JampPowerが0以上だったらプレイヤーのポジションをプラスする
        if (JumpPower < 0.0f) return;
        var nowpos = transform.position;
        nowpos.z += JumpPower;
        transform.position = nowpos;
        //毎フレームジャンプ力を下げる
        JumpPower -= JumpDecPow;

    }
}
