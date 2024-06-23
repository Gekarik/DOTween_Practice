using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;
    [SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DOScale(_scale,_duration)
            .SetEase(_ease)
            .SetLoops(_repeats,_loopType);
    }
}
