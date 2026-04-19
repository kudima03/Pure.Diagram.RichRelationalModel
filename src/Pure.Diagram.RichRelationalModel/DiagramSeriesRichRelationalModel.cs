using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel;

public sealed record DiagramSeriesRichRelationalModel : IDiagramSeriesRichRelationalModel
{
    public DiagramSeriesRichRelationalModel(IDiagramSeriesRichRelationalModel richModel)
        : this(
            richModel.Id,
            richModel.DiagramId,
            (richModel as IDiagramSeriesRelationalModel).Label,
            (richModel as IDiagramSeriesRelationalModel).Source
        )
    { }

    public DiagramSeriesRichRelationalModel(
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
