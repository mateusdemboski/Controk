namespace Controk.SagaOrchestrator.StateMachines;

using Controk.SagaOrchestrator.StateInstances;
using MassTransit;

internal sealed class MovementStateMachine
    : MassTransitStateMachine<MovementState>
{
    public MovementStateMachine()
    {
        this.InstanceState(x => x.CurrentState);
    }
}
