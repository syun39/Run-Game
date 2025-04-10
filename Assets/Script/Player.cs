using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] private int _speed = 50; //�v���C���[�̑��x

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidBody.velocity = new Vector3(Input.GetAxis("Horizontal") * _speed, 0, 10);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal") //�I�u�W�F�N�g�̖��O�������Ă�����
        {
            _rigidBody.velocity = Vector3.zero;
        }
    }
}
