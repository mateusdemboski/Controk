namespace Controk.Extensions.Mapping.Abstractions;

public interface IBuilder
{
    TOutput Build<TInput, TOutput>(TInput input)
        where TInput : class;
}
