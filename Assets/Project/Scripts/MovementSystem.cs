using Leopotam.Ecs;
using UnityEngine;

public class MovementSystem : IEcsRunSystem
{
    private EcsWorld _world = null;
    private EcsFilter<MoveComponent, DirectionComponent, TransformComponent> _filter = null;

    public void Run()
    {
        foreach (var idx in _filter)
        {
            ref var moveComponent = ref _filter.Get1(idx);
            ref var directionComponent = ref _filter.Get2(idx);
            ref var transformComponent = ref _filter.Get3(idx);

            ref var transform = ref transformComponent.transform;
            ref var direction = ref directionComponent.direction;

            Vector3 moveDirection = transform.forward * direction.z + transform.right * direction.x;
            moveComponent.characterController.Move(moveDirection * moveComponent.speed * Time.deltaTime);
        }
    }
}