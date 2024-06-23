using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _repeats = -1;

    void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode)
            .SetEase(_ease)
            .SetLoops(_repeats, _loopType);
    }
}
