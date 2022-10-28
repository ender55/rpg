using Leopotam.Ecs;

public class PlayerMovementSystem : IEcsRunSystem
{
    private EcsWorld _world = null;
    private EcsFilter<PlayerTag, MoveComponent> _filter = null;
    private PlayerInput _playerInput = null;
    
    public void Run()
    {
        //todo: сделать систему для direction
        throw new System.NotImplementedException();
    }
}