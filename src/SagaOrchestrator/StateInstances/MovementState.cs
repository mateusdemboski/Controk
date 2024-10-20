namespace Controk.SagaOrchestrator.StateInstances;

using MassTransit;

internal sealed class MovementState :
    SagaStateMachineInstance,
    ISagaVersion
{
    public Guid CorrelationId { get; set; }

    public string CurrentState { get; set; } = default!;

    public int Version { get; set; }
}
