using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel;

public sealed record DiagramRichRelationalModel : IDiagramRichRelationalModel
{
    public DiagramRichRelationalModel(IDiagramRichRelationalModel richModel)
        : this(
            richModel.Id,
            (richModel as IDiagramRelationalModel).Title,
            (richModel as IDiagramRelationalModel).Description,
            richModel.TypeId,
            richModel.Type,
            richModel.Series
        )
    { }

    public DiagramRichRelationalModel(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
    {
        Id = id;
        Title = title;
        Description = description;
        TypeId = typeId;
        Type = type;
        Series = series;
    }

    public IGuid Id { get; }

    public IString Title { get; }

    public IString Description { get; }

    public IGuid TypeId { get; }

    public IDiagramType Type { get; }

    public IEnumerable<ISeries> Series { get; }
}
