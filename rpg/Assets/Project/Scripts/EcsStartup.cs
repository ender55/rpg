using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsStartup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;

    public PlayerInput PlayerInput;
    
    private void Start()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);

        _systems.ConvertScene();
        
        AddInjections();
        AddOneFrame();
        AddSystems();
        
        _systems.Init();
    }

    private void AddSystems()
    {
        
    }
    
    private void AddInjections()
    {
        _systems.Inject(PlayerInput);
    }
    
    private void AddOneFrame()
    {
        
    }
    
    private void Update()
    {
        _systems.Run();
    }

    private void OnDestroy()
    {
        if (_systems == null) return;

        _systems.Destroy();
        _systems = null;
        _world.Destroy();
        _world = null;
    }
}