using System;
using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsStartup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;
    
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