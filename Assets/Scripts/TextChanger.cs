using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private string _textToReplace;
    [SerializeField] private string _textToAdd;
    [SerializeField] private string _textToHack;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Sequence _sequence;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        _sequence = DOTween.Sequence();
        _sequence.Append(Replace()).Append(Add()).Append(Hack()).SetLoops(_repeats, _loopType);
    }

    private Tween Replace() => _text.DOText(_textToReplace, _duration);

    private Tween Add() => _text.DOText(_textToAdd, _duration).SetRelative();

    private Tween Hack() => _text.DOText(_textToHack, _duration, true, ScrambleMode.All);
}
