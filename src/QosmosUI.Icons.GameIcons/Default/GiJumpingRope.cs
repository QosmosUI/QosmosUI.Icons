// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiJumpingRope : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 24c-67.8 0-111.5 43.46-132.4 97.8-20 52-20.8 114.2-6.1 163.5l14.2-16.1c-10.1-43.5-8.1-97.2 8.7-141C159.5 78.54 195.7 42 256 42c60.2 0 96.5 36.54 115.6 86.2 16.8 43.8 18.8 97.5 8.7 141l14.2 16.1c14.7-49.3 13.9-111.5-6.1-163.5C367.5 67.46 323.8 24 256 24zm0 92.8c-18.2 0-34.2 17.8-34.2 41.6s16 41.6 34.2 41.6c18.2 0 34.2-17.8 34.2-41.6s-16-41.6-34.2-41.6zM231.3 211c-17.3 3.8-31.3 10.2-33.9 11.4l-74.6 84 8.3 16.6 85.9-68.7V417h30v-64h18v135h30V254.3l85.9 68.7 8.3-16.6-74.6-84c-2.6-1.2-16.6-7.6-33.9-11.4-7.3 4.4-15.7 7-24.7 7s-17.4-2.6-24.7-7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
