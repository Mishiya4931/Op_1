using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepObject : MonoBehaviour
{
    private PlayerCtrl Player;
    [SerializeField] private float JumpPower = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.AddComponent<PlayerCtrl>();
        Physics.gravity = new Vector3(0, 0, -5.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.CompareTag("Player")) 
        {
            if (_other.gameObject.transform.position.z < transform.position.z) return;//�v���C���[�̃|�W�V��������Q���������̏ꍇ�������Ȃ�
            PlayerCtrl playerCtrl = _other.gameObject.GetComponent<PlayerCtrl>();
            if (playerCtrl != null)
            {
                playerCtrl.JumpPower = JumpPower;
            }

            Rigidbody rb = GetComponent<Rigidbody>();

            // ���x�����Z�b�g�i�Î~��Ԃɖ߂��j
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
