using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using PureGuid = Pure.Primitives.Guid.Guid;
using PureString = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.Tests;

public sealed class DiagramSeriesRichRelationalModelTests
{
    [Fact]
    public void SetsId()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsDiagramId()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        Assert.Equal(diagramId.GuidValue, sut.DiagramId.GuidValue);
    }

    [Fact]
    public void SetsLabel()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        Assert.Equal(label.TextValue, sut.Label.TextValue);
    }

    [Fact]
    public void SetsSource()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        Assert.Equal(source.TextValue, sut.Source.TextValue);
    }

    [Fact]
    public void SetsIdByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);
        IDiagramSeriesRichRelationalModel original = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            original
        );

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsDiagramIdByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);
        IDiagramSeriesRichRelationalModel original = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            original
        );

        Assert.Equal(diagramId.GuidValue, sut.DiagramId.GuidValue);
    }

    [Fact]
    public void SetsLabelByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);
        IDiagramSeriesRichRelationalModel original = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            original
        );

        Assert.Equal(label.TextValue, sut.Label.TextValue);
    }

    [Fact]
    public void SetsSourceByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IGuid diagramId = new PureGuid(Guid.NewGuid());
        IString label = new PureString(id);
        IString source = new PureString(diagramId);
        IDiagramSeriesRichRelationalModel original = new DiagramSeriesRichRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        DiagramSeriesRichRelationalModel sut = new DiagramSeriesRichRelationalModel(
            original
        );

        Assert.Equal(source.TextValue, sut.Source.TextValue);
    }
}
