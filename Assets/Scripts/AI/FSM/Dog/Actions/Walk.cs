using AiManager;
using UnityEngine;

namespace AI.FSM
{
    [CreateAssetMenu (menuName = "FSM/Dog/Action/Walk")]
    public class Walk : Action
    {
        public override void Act(AiComponentController controller)
        {
            Vector3 point = controller.getRandomMovementPoint();
            controller.navMeshAgent.SetDestination(point);
        }
    }
}