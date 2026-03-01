using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using PureGuid = Pure.Primitives.Guid.Guid;
using PureString = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.Tests;

public sealed class DiagramTypeRichRelationalModelTests
{
    [Fact]
    public void SetsId()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString name = new PureString(id);

        DiagramTypeRichRelationalModel sut = new DiagramTypeRichRelationalModel(id, name);

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsName()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString name = new PureString(id);

        DiagramTypeRichRelationalModel sut = new DiagramTypeRichRelationalModel(id, name);

        Assert.Equal(name.TextValue, sut.Name.TextValue);
    }

    [Fact]
    public void SetsIdByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString name = new PureString(id);
        IDiagramTypeRichRelationalModel source = new DiagramTypeRichRelationalModel(id, name);

        DiagramTypeRichRelationalModel sut = new DiagramTypeRichRelationalModel(source);

        Assert.Equal(id.GuidValue, sut.Id.GuidValue);
    }

    [Fact]
    public void SetsNameByCopyCtor()
    {
        IGuid id = new PureGuid(Guid.NewGuid());
        IString name = new PureString(id);
        IDiagramTypeRichRelationalModel source = new DiagramTypeRichRelationalModel(id, name);

        DiagramTypeRichRelationalModel sut = new DiagramTypeRichRelationalModel(source);

        Assert.Equal(name.TextValue, sut.Name.TextValue);
    }
}