using System;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsStartup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _updateSystems;
    private EcsSystems _fixedUpdateSystems;

    public PlayerInput PlayerInput;
    
    private void Start()
    {
        _world = new EcsWorld();
        _updateSystems = new EcsSystems(_world);
        _fixedUpdateSystems = new EcsSystems(_world);

        _updateSystems.ConvertScene();
        _fixedUpdateSystems.ConvertScene();
        
        AddInjections();
        AddOneFrame();
        AddSystems();
        
        _updateSystems.Init();
        _fixedUpdateSystems.Init();
    }

    private void AddSystems()
    {
        _updateSystems.
            Add(new MoveInputSystem()).
            Add(new MovementSystem());
    }
    
    private void AddInjections()
    {
        _updateSystems.Inject(PlayerInput);
    }
    
    private void AddOneFrame()
    {
        
    }
    
    private void Update()
    {
        _updateSystems.Run();
    }

    private void FixedUpdate()
    {
        _fixedUpdateSystems.Run();
    }

    private void OnDestroy()
    {
        if (_updateSystems == null) return;

        _updateSystems.Destroy();
        _updateSystems = null;
        _world.Destroy();
        _world = null;
    }
}