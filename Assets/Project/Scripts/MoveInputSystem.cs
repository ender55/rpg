using Leopotam.Ecs;
using UnityEngine;

public class MoveInputSystem : IEcsRunSystem
{
    private EcsWorld _world = null;
    private EcsFilter<ControllableComponent, DirectionComponent> _filter = null;
    private PlayerInput _playerInput = null;
        
    public void Run()
    {
        foreach (var idx in _filter)
        {
            ref var directionComponent = ref _filter.Get2(idx);
            directionComponent.direction = CalculateDirection();
        }
    }
    
    //todo: попробовать сделать функцию менее громозкой
    
    private Vector3 CalculateDirection()
    {
        var direction = Vector3.zero;
        
        if (Input.GetKey(_playerInput.Forward))
        {
            direction += Vector3.forward;
        }
        
        if (Input.GetKey(_playerInput.Backward))
        {
            direction += Vector3.back;
        }
        
        if (Input.GetKey(_playerInput.Right))
        {
            direction += Vector3.right;
        }
        
        if (Input.GetKey(_playerInput.Left))
        {
            direction += Vector3.left;
        }

        return direction.normalized;
    }
}