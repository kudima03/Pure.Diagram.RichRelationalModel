# Pure.Diagram.RichRelationalModel

Concrete immutable record implementations of the rich relational diagram model for the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel` provides sealed record implementations for diagram domain entities that combine both the structural (model) and relational aspects into a single strongly-typed, immutable object. Each record implements a corresponding interface from `Pure.Diagram.RichRelationalModel.Abstractions`.

A "rich relational" model carries not only foreign-key identifiers but also the fully resolved navigation objects — e.g. a `DiagramRichRelationalModel` holds both `TypeId` (`IGuid`) and `Type` (`IDiagramType`).

## Types

| Type | Implements | Properties |
|------|-----------|------------|
| `DiagramRichRelationalModel` | `IDiagramRichRelationalModel` | `Id`, `Title`, `Description`, `TypeId`, `Type`, `Series` |
| `DiagramSeriesRichRelationalModel` | `IDiagramSeriesRichRelationalModel` | `Id`, `DiagramId`, `Label`, `Source` |
| `DiagramTypeRichRelationalModel` | `IDiagramTypeRichRelationalModel` | `Id`, `Name` |

## Dependencies

- [`Pure.Diagram.RichRelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions) — rich relational diagram interfaces
