namespace Controk.Extensions.Mapping.Abstractions;

public interface IBuilder<in TInput, out TOutput>
{
    TOutput Build(TInput input);
}
