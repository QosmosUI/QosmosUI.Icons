// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEggEye : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32C160 32 96 192 96 320c0 64 32 160 160 160s160-96 160-160c0-128-64-288-160-288zm74.1 89.2l11.8 13.6-53 46.7 8.8 14.6c31.1 34.3 62.9 65.8 97.4 96.4l-12 13.4-19.6-17.3-25.7 114.6-17.6-4 16.4-73c-46.8-15-93.2-31.5-140.1-46.3-3.9 1.6-8 2.9-12 4.3l-6.7 36.6 51 31.9-9.6 15.2-44.9-28.1-5.4 29.8-17.8-3.2 13.8-75.4-33.9 11.8-6-17 63.7-22.2 21.6-9.3 70.9-50.9-32.9-54.8 15.4-9.2 15.8 26.4 50.6-44.6zM288 236.5c-22.1.2-37.7 13-44.6 42.7 47.1 16.7 71.4-.2 84.5-33.4-14.9-6.2-28.3-9.5-39.9-9.3zm-6 6.9a10.24 10.37 0 0 0-1.1 4.8 10.24 10.37 0 0 0 10.2 10.4 10.24 10.37 0 0 0 9.6-6.8 18.38 17.35 0 0 1 2.5 8.7 18.38 17.35 0 0 1-18.4 17.3 18.38 17.35 0 0 1-18.3-17.3 18.38 17.35 0 0 1 15.5-17.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
