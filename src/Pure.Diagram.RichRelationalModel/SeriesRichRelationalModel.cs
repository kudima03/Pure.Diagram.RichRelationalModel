using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel;

public sealed record SeriesRichRelationalModel : ISeriesRichRelationalModel
{
    public SeriesRichRelationalModel(ISeriesRichRelationalModel richModel)
        : this(
            richModel.Id,
            richModel.DiagramId,
            (richModel as ISeriesRelationalModel).Label,
            (richModel as ISeriesRelationalModel).Source
        )
    { }

    public SeriesRichRelationalModel(
        IGuid id,
        IGuid diagramId,
        IString label,
        IString source
    )
    {
        Id = id;
        DiagramId = diagramId;
        Label = label;
        Source = source;
    }

    public IGuid Id { get; }

    public IGuid DiagramId { get; }

    public IString Label { get; }

    public IString Source { get; }
}
