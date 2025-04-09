using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] private float JumpDecPow = 0.0f;
    public float JumpPower;//�|�W�V�����ɉ�����ϐ�
    // Start is called before the first frame update
    void Start()
    {
        JumpPower = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //JampPower��0�ȏゾ������v���C���[�̃|�W�V�������v���X����
        if (JumpPower < 0.0f) return;
        var nowpos = transform.position;
        nowpos.z += JumpPower;
        transform.position = nowpos;
        //���t���[���W�����v�͂�������
        JumpPower -= JumpDecPow;

    }
}
