// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBrute : ComponentBase
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
		builder.AddAttribute(14, "d", "M448 36c-29.4 44.05-63.2 65.7-126.3 64.8A79.99 75.99 0 0 0 256 68.01a79.99 75.99 0 0 0-65.8 32.79c-63 .9-96.85-20.77-126.2-64.8-30.29 45.43 21.04 110.9 112.2 112.4a79.99 75.99 0 0 0 8.1 29.2C44.84 197.1 16.82 388.1 32 464h80c0-48 16-112 64-144l-16 144c0 16 64 16 64 0 0-32 16-64 32-64s32 32 32 64c0 16 64 16 64 0l-16-144c48 32 64 96 64 144h80c15.2-75.9-12.8-267-152.4-286.4a79.99 75.99 0 0 0 8.2-29.2C426.9 146.9 478.3 81.44 448 36zm-256 87.8c13.5 15.7 27.2 31.3 48 40.2 0 0-22.9 15.7-32 8.7-10.1-7.9-16-48.9-16-48.9zm128 0s-5.9 41-16 48.9c-9.1 7-32-8.7-32-8.7 20.8-8.9 34.5-24.5 48-40.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
