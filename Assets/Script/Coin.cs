using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject _scoreController;

    private void Start()
    {
        //ScoreControllerオブジェクトを見つける
        _scoreController = GameObject.Find("ScoreController");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //ScoreControllerオブジェクトについてるScriptのメソッドを使用
            _scoreController.GetComponent<ScoreController>().AddScore(1);
            Destroy(gameObject); //削除
        }
    }
}
