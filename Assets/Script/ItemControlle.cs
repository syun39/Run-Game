using UnityEngine;

public class ItemController : MonoBehaviour
{

    [SerializeField] private GameObject _cubePrefab;

    [SerializeField] private float _zPos = 424; //生成のスタート地点
    [SerializeField] private float _distance = 848; //スタートからゴールまでの距離
    [SerializeField] private float _posInterval = 12; //cubeのscaleが7なので5mの間隔をあけるために7+5


    void Start()
    {
        for (int i = 0; i < _distance / _posInterval; i++) //スタートからゴールまでの距離を生成間隔で割る
        {
            _zPos -= _posInterval;
            Instantiate(_cubePrefab, new Vector3(0, 2, _zPos),transform.rotation);
        }
    }
}
