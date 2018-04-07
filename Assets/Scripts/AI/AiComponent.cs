using UnityEngine;
using System.Collections.Generic;
namespace AiManager
{
    public class AiComponent:AiComponentSensor
    {
     private Vector3 position;
     private float sensorRange;
     private AiComponentManager aiComponentManager;
     public AiComponent(AiComponentManager aiComponentManager){
         this.aiComponentManager = aiComponentManager;
     }
     public void notifyNearbyComponents(List<AiComponent> nearbyComponents){} 
     public  Vector3 getPosition(){return this.position;}
     public float getSensorRange(){return this.sensorRange;}
    }
}