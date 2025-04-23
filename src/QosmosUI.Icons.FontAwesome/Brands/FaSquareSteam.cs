// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaSquareSteam : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M165.6 309.1c18.6 7.7 27.3 28.9 19.6 47.4s-29 27.2-47.6 19.4l-28.5-11.8c5 10.6 13.8 19.4 25.4 24.2c25.2 10.5 54.1-1.4 64.6-26.5c5.1-12.1 5.1-25.5 .1-37.7c-5.1-12.1-14.5-21.6-26.7-26.7c-12.1-5-25-4.8-36.4-.5l29.5 12.2zM448 96c0-35.3-28.7-64-64-64H64C28.7 32 0 60.7 0 96V240.7l116.6 48.1c12-8.2 26.2-12.1 40.7-11.3l55.4-80.2v-1.1c0-48.2 39.3-87.5 87.6-87.5s87.6 39.3 87.6 87.5c0 49.2-40.9 88.7-89.6 87.5l-79 56.3c1.6 38.5-29.1 68.8-65.7 68.8c-31.8 0-58.5-22.7-64.5-52.7L0 319.2V416c0 35.3 28.7 64 64 64H384c35.3 0 64-28.7 64-64V96zM241.9 196.2a58.4 58.4 0 1 0 116.8 0 58.4 58.4 0 1 0 -116.8 0zm14.6-.1a43.9 43.9 0 1 1 87.8 0 43.9 43.9 0 1 1 -87.8 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
