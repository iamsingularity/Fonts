﻿using SixLabors.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SixLabors.Fonts
{
    /// <summary>
    /// A surface that can have a glyph renered to it as a series of actions.
    /// </summary>
    public interface IGlyphRenderer
    {
        /// <summary>
        /// Begins the figure.
        /// </summary>
        void BeginFigure();

        /// <summary>
        /// Sets a new start point to draw lines from
        /// </summary>
        /// <param name="point">The point.</param>
        void MoveTo(PointF point);

        /// <summary>
        /// Draw a quadratic bezier curve connecting the previous point to <paramref name="point"/>.
        /// </summary>
        /// <param name="secondControlPoint">The second control point.</param>
        /// <param name="point">The point.</param>
        void QuadraticBezierTo(PointF secondControlPoint, PointF point);

        /// <summary>
        /// Draw a Cubics bezier curve connecting the previous point to <paramref name="point"/>.
        /// </summary>
        /// <param name="secondControlPoint">The second control point.</param>
        /// <param name="thirdControlPoint">The third control point.</param>
        /// <param name="point">The point.</param>
        void CubicBezierTo(PointF secondControlPoint, PointF thirdControlPoint, PointF point);

        /// <summary>
        /// Draw a straight line connecting the previous point to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The point.</param>
        void LineTo(PointF point);

        /// <summary>
        /// Ends the figure.
        /// </summary>
        void EndFigure();

        /// <summary>
        /// Ends the glyph.
        /// </summary>
        void EndGlyph();

        /// <summary>
        /// Begins the glyph.
        /// </summary>
        /// <param name="location">The location the glyph will be rendered.</param>
        /// <param name="size">The size of the glyphe that will be rendered.</param>
        void BeginGlyph(PointF location, SizeF size);


        /// <summary>
        /// Called once all glyphs have completed rendering
        /// </summary>
        void EndText();

        /// <summary>
        /// Called before any glyphs have been rendered.
        /// </summary>
        /// <param name="location">The location of the origion of the glyphs being renderd.</param>
        /// <param name="size">The size of the bounding box around all the glyphs.</param>
        void BeginText(PointF location, SizeF size);
    }
}
