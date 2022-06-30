using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IMoveble))]
public class Movement : MonoBehaviour
{
    [SerializeField]private float _speed=1f;

    private Vector3 _target;
    private bool _reached;

    public void StartMoving() 
    {
        
        _target = RandomPosition.GetRandomPosition();
        
        StartCoroutine(MoveToPoint());
    }

    private IEnumerator MoveToPoint() 
    {
        _reached = false;
        float step=0;
        while (!_reached) 
        {
            step = _speed * Time.deltaTime;
            transform.LookAt(_target);
            transform.position = Vector3.MoveTowards(transform.position,_target,step);
            
            if (Vector3.Distance(transform.position, _target) < 0.001f)
            {
                _target = RandomPosition.GetRandomPosition();
            }

            yield return new WaitForEndOfFrame();
            
        }
        
    }
    public void SetSpeed(float newSpeed) => _speed = newSpeed;
}
