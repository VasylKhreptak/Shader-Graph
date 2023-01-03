using CBA.Actions.Core;
using CBA.Animations.Transform.Move.PositionProvider.Core;
using UnityEngine;

public class SetMaterialPosition : Action
{
    [Header("References")]
    [SerializeField] private PositionProvider _positionProvider;
    [SerializeField] private Material _material;
    [SerializeField] private string _propertyName = "_MagnetPosition";

    public override void Do()
    {
        _material.SetVector(_propertyName, _positionProvider.position);
    }
}
