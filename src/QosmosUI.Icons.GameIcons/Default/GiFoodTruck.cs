// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFoodTruck : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M267.2 25.08l-70 70.16c-7.7 7.66-7.3 16.86-2.4 26.96l2 4.3-3.1 2.9-23.6 22.3 21.7 21.6 22.2-23.7 2.9-3 4.2 1.9c10.7 5.3 20.6 5.7 27.7-1.4L319 76.85l-10.2-10.18-45.7 45.63-9.6-9.8L299 56.97l-10.9-11.03-45.5 45.7-9.7-9.7 45.5-45.69zM28.97 27.84c-5.73 9.12-6.61 20.83-3.32 34.58 3.87 16.32 13.68 35.22 27.41 53.08 27.35 35.8 50.04 48.1 86.84 54.8l2.4.4c13.6 16.1 27.2 32.1 40.8 48.2h37.1zM137 183.2l-37.74 35.7h49.64l9.7-10.3zM26.25 232.9v63.5l16.51-49.5H279.8l16.5 49.5v-63.5zm29.49 32l-10 30h45.04l10.02-30zm63.96 0l-10 30h42.6v-30zm50.6 0v30h42.6l-10-30zm51.4 0l10 30h45.1l-10-30zm92.6 1.8v188.2h79c4.2-18.2 20.6-32 40-32s35.8 13.8 40 32h15v-64l-56.2-14H328.3v-82H390l-6.9-15zM26.25 312.9v114.2l42.17 27.8h14.85c4.14-18.2 20.53-32 40.03-32 19.4 0 35.8 13.8 40 32h133v-142h-14v80H40.25v-80zm320.05 0v46h72.4l-23-46zm-281.05 19l16 16h16l16.05-16zm-8 27v18H265.3v-18zm66.05 82c-12.9 0-23.1 10.2-23.1 23s10.2 23 23.1 23c12.8 0 23-10.2 23-23s-10.2-23-23-23zm310 0c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
