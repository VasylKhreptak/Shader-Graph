using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Preferences")]
    [SerializeField] private Transform _transform;
    [SerializeField] private Vector3 _angle;
    [SerializeField] private float _speed;

    #region MonoBehaviour

    private void OnValidate()
    {
        _transform ??= GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.rotation = Quaternion.Euler(_angle * Time.deltaTime * _speed) * _transform.rotation;
    }

    #endregion
}
