using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] int _score; //�X�R�A
    [SerializeField] Text _text;
    void Start()
    {
        _score = 0;
    }
    void Update()
    {
        _text.text = _score.ToString();
    }

    //�X�R�A�����Z
    public void AddScore(int value)
    {
        _score += value;
    }
}
