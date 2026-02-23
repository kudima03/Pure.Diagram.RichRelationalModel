using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel;

public sealed record DiagramTypeRichRelationalModel : IDiagramTypeRichRelationalModel
{
    public DiagramTypeRichRelationalModel(IDiagramTypeRichRelationalModel richModel)
        : this(richModel.Id, (richModel as IDiagramTypeRelationalModel).Name) { }

    public DiagramTypeRichRelationalModel(IGuid id, IString name)
    {
        Id = id;
        Name = name;
    }

    public IGuid Id { get; }

    public IString Name { get; }
}
