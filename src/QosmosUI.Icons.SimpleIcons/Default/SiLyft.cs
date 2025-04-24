// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLyft : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M4.38 15.883c.036.042.125.135.125.135s-.094.059-.152.086a3.046 3.046 0 0 1-1.28.286C1.593 16.39 0 15.29 0 12.878v-8.78h3.512v9.365c0 .95.306 1.781.867 2.42zM24 11.122V7.61h-1.253c-.524-2.76-3.425-4.574-6.341-3.484-1.624.607-2.943 2.548-2.943 4.282v7.979a1608.8 1608.8 0 0 0 .153 0 3.495 3.495 0 0 0 2.38-1.077c.632-.658.98-1.522.98-2.432h1.463V9.366h-1.463V8.4c0-.375.198-.726.526-.909.9-.5 1.815.143 1.815.996v3.22c0 1.273.48 2.456 1.354 3.329a4.666 4.666 0 0 0 3.178 1.351H24v-3.51a1.17 1.17 0 0 1-1.17-1.17v-.586H24zm-14.927 1.17a.585.585 0 0 1-1.17 0V7.61H4.39v5.853a2.928 2.928 0 0 0 4.83 2.224c-.055.433-.294.792-.69 1.04-.373.234-.857.357-1.402.357a3.83 3.83 0 0 1-1.65-.382s-.093-.044-.21-.11v3.119a6.65 6.65 0 0 0 2.468.484c1.312 0 2.51-.41 3.371-1.155.967-.836 1.478-2.056 1.478-3.528V7.61H9.073v4.683z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
