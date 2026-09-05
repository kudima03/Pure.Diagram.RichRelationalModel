# Changelog

All notable changes to Pure.Diagram.RichRelationalModel are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- Dependency on `Pure.Diagram.RichRelationalModel.Abstractions` bumped to
  `0.1.0-preview.1.0.0`.
- **Breaking:** `SeriesRichRelationalModel` renamed to
  `DiagramSeriesRichRelationalModel`, implementing
  `IDiagramSeriesRichRelationalModel`.
- **Breaking:** `DiagramRichRelationalModel.Series` changed from
  `IEnumerable<ISeries>` to `IEnumerable<IDiagramSeries>`.

## [0.1.0-preview.0.1.0] — 2026-02-23

### Added

- **`DiagramRichRelationalModel`** — sealed record implementing
  `IDiagramRichRelationalModel`, combining `Id`, `Title`, `Description`,
  `TypeId`, `Type`, and `Series`.
- **`SeriesRichRelationalModel`** — sealed record implementing
  `ISeriesRichRelationalModel`, combining `Id`, `DiagramId`, `Label`, and
  `Source`.
- **`DiagramTypeRichRelationalModel`** — sealed record implementing
  `IDiagramTypeRichRelationalModel`, combining `Id` and `Name`.
- Targets `net7.0`, `net8.0`, `net9.0`, `net10.0`; AOT-compatible.
