// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLeak : ComponentBase
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
		builder.AddAttribute(14, "d", "M367 32s-37.8 51.9-32 80c3 14.8 16.9 32 32 32 15.1 0 29-17.2 32-32 5.8-28.1-32-80-32-80zM160.2 133.4s-37.8 51.9-32 80c3 14.8 16.9 32 32 32 15.1 0 29-17.2 32-32 5.8-28.1-32-80-32-80zm241.1 134.1a91.23 38.36 0 0 0-83.9 23.4 210 77.59 0 0 0-79.7-5.9 210 77.59 0 0 0-210 77.6 210 77.59 0 0 0 210 77.6 210 77.59 0 0 0 68.2-4.3 82.62 29.64 0 0 0-4.5 9.6 82.62 29.64 0 0 0 82.6 29.6 82.62 29.64 0 0 0 82.6-29.6 82.62 29.64 0 0 0-76.8-29.5 210 77.59 0 0 0 57.9-53.4 210 77.59 0 0 0-8.6-21.8 91.23 38.36 0 0 0 53.4-34.9 91.23 38.36 0 0 0-91.2-38.4zM107.8 457.6A43.89 17.43 0 0 0 63.91 475a43.89 17.43 0 0 0 43.89 17.4 43.89 17.43 0 0 0 43.9-17.4 43.89 17.43 0 0 0-43.9-17.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
