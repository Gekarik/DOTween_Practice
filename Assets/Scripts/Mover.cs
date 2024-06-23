using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _newPosition;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DOMove(_newPosition, _duration).SetLoops(_repeats, _loopType).SetEase(_ease);
    }
}
