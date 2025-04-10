using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] int _score; //スコア
    [SerializeField] Text _text;
    void Start()
    {
        _score = 0;
    }
    void Update()
    {
        _text.text = _score.ToString();
    }

    //スコアを加算
    public void AddScore(int value)
    {
        _score += value;
    }
}
