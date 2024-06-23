using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorSwithcer : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration = 3;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private Ease _ease;

    private Material _material;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;

        _material.DOColor(_color, _duration)
            .SetEase(_ease)
            .SetLoops(_repeats, _loopType);

    }
}
