// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Numerics;
using SixLabors.Fonts.Tables.General.Glyphs;
using SixLabors.Fonts.Unicode;

namespace SixLabors.Fonts.Tests.Fakes
{
    internal class FakeGlyphSource
    {
        public FakeGlyphSource(CodePoint codePoint, ushort index)
            : this(
                  codePoint,
                  index,
                  new GlyphVector(
                      new Vector2[] { new Vector2(10, 10), new Vector2(10, 20), new Vector2(20, 20), new Vector2(20, 10) },
                      new bool[] { true, true, true, true },
                      new ushort[] { 3 },
                      new Bounds(10, 10, 20, 20),
                      Array.Empty<byte>()))
        {
        }

        public FakeGlyphSource(CodePoint codePoint, ushort index, GlyphVector vector)
        {
            this.CodePoint = codePoint;
            this.Vector = vector;
            this.Index = index;
        }

        public CodePoint CodePoint { get; }

        public ushort Index { get; }

        public GlyphVector Vector { get; }
    }
}
