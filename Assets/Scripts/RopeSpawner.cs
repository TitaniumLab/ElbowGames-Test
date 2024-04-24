using System.IO;
using UnityEngine;
using UnityEngine.Pool;
using Zenject;

public class RopeSpawner : MonoBehaviour
{
    [SerializeField] private HingeJoint2D _ropePrefab;
    [SerializeField] private Transform _ropeParent;

    private ObjectPool<HingeJoint2D> _pool;

    private void Awake() =>
        _pool = new ObjectPool<HingeJoint2D>(CreateUnit, GetUnit, ReleaseUnit);

    #region Pool
    public HingeJoint2D Get()
    { return _pool.Get(); }


    public void Release(HingeJoint2D segment) =>
        _pool.Release(segment);

    private HingeJoint2D CreateUnit()
    {
        var unit = Object.Instantiate(_ropePrefab, _ropeParent);
        return unit;
    }

    private void GetUnit(HingeJoint2D segment) =>
        segment.gameObject.SetActive(true);

    private void ReleaseUnit(HingeJoint2D segment) =>
        segment.gameObject.SetActive(false);
    #endregion
}
