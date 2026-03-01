using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using PureGuid = Pure.Primitives.Guid.Guid;
using PureString = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.Tests;

public sealed class DiagramRichRelationalModelTests
{
    [Fact]
    public void SetsId()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsTitle()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Equal(title.TextValue, sut.Title.TextValue);
    }

    [Fact]
    public void SetsDescription()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Equal(description.TextValue, sut.Description.TextValue);
    }

    [Fact]
    public void SetsTypeId()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Equal(typeId.GuidValue, sut.TypeId.GuidValue);
    }

    [Fact]
    public void SetsType()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IString typeName = new PureString(typeInternalId);
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, typeName);
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Equal(typeName.TextValue, sut.Type.Name.TextValue);
    }

    [Fact]
    public void SetsSeries()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        Assert.Empty(sut.Series);
    }

    [Fact]
    public void SetsIdByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsTitleByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Equal(title.TextValue, sut.Title.TextValue);
    }

    [Fact]
    public void SetsDescriptionByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Equal(description.TextValue, sut.Description.TextValue);
    }

    [Fact]
    public void SetsTypeIdByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Equal(typeId.GuidValue, sut.TypeId.GuidValue);
    }

    [Fact]
    public void SetsTypeByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IString typeName = new PureString(typeInternalId);
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, typeName);
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Equal(typeName.TextValue, sut.Type.Name.TextValue);
    }

    [Fact]
    public void SetsSeriesByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString title = new PureString(id);
        IString description = new PureString(id);
        IGuid typeId = new PureGuid(Guid.NewGuid());
        IGuid typeInternalId = new PureGuid(Guid.NewGuid());
        IDiagramType type = new DiagramTypeRichRelationalModel(typeInternalId, new PureString(typeInternalId));
        IEnumerable<ISeries> series = [];
        IDiagramRichRelationalModel original = new DiagramRichRelationalModel(id, title, description, typeId, type, series);

        DiagramRichRelationalModel sut = new DiagramRichRelationalModel(original);

        Assert.Empty(sut.Series);
    }
}