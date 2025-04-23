// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdPanoramaPhotosphereSelect : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M22.49 8.51c-.47-.23-.93-.44-1.4-.64C19.52 4.41 16.05 2 12 2S4.47 4.41 2.9 7.88c-.47.2-.93.41-1.4.63-.31.15-.5.48-.5.83v5.32c0 .35.19.68.51.83.47.23.93.44 1.39.64 3.55 7.83 14.65 7.82 18.2 0 .47-.2.93-.41 1.39-.63.31-.17.51-.49.51-.84V9.34c0-.35-.19-.68-.51-.83zM12 3.8c2.6 0 4.91 1.23 6.41 3.12-4.1-1.19-8.48-1.26-12.83.01C7.08 5.03 9.4 3.8 12 3.8zM5.6 17.08c4.19 1.22 8.57 1.23 12.82-.01-1.54 1.97-3.9 3.13-6.41 3.13-2.5 0-4.87-1.15-6.41-3.12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
