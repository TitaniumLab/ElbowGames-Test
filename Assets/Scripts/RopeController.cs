using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RopeController : MonoBehaviour
{
    [SerializeField] private HingeJoint2D _lastSeg;
    [SerializeField] private Rigidbody2D _hook;
    [SerializeField] private float _nextSegmentCounter = 0;
    [SerializeField] private int _segmetnCounter;
    [SerializeField] private float _ropeSpeed = 1;
    private Stack<HingeJoint2D> _segments = new Stack<HingeJoint2D>();
    private RopeSpawner _spawner;
    private IVerticalInput _verticalInput;

    [Inject]
    private void Construct(RopeSpawner spawner, IVerticalInput verticalInput)
    {
        _spawner = spawner;
        _verticalInput = verticalInput;
        _verticalInput.OnVerticalInput += ChangeRope;
    }


    private void Awake()
    {
        _segments.Push(_lastSeg);
        _segmetnCounter = _segments.Count;
    }

    #region Methods
    private void ChangeRope(float value)
    {
        if (value > 0)
        {
            _nextSegmentCounter += value * Time.deltaTime * _ropeSpeed;
            if (_nextSegmentCounter > 1)
            {
                GetSegment();
                _nextSegmentCounter = 0;
            }
        }
        else
        {
            _nextSegmentCounter -= value * Time.deltaTime * _ropeSpeed;
            if (_nextSegmentCounter < -1)
            {
                if (_segmetnCounter > 1)
                    RemoveSegment();
                _nextSegmentCounter = 0;
            }
        }
    }

    private void GetSegment()
    {
        HingeJoint2D newSeg = _spawner.Get();
        _segments.Peek().connectedBody = newSeg.GetComponent<Rigidbody2D>();
        newSeg.connectedBody = _hook;
        _segments.Push(newSeg);
        _segmetnCounter++;
    }

    private void RemoveSegment()
    {
        _spawner.Release(_segments.Pop());
        _segmetnCounter--;
        _segments.Peek().connectedBody = _hook;
    }
    #endregion
}
