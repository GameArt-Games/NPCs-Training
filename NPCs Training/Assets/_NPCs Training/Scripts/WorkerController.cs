using UnityEngine;

public class WorkerController : MonoBehaviour
{
    [SerializeField] Transform[] _targetPoints;
    [SerializeField] float _speed = 1;
    int _i = 0;

    // Update is called once per frame
    void Update()
    {
        MoveAmongPoint();
    }

    public void MoveAmongPoint()
    {
        if (_targetPoints.Length <= _i)
        {
            _i = 0;
        }

        float distance = Vector3.Distance(transform.position, _targetPoints[_i].position);

        if (distance > 0.1)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPoints[_i].position, _speed * Time.deltaTime);
            transform.LookAt(_targetPoints[_i]);
        }
        else
        {
            _i++;
        }
    }
}
