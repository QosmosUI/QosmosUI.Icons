// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHeartShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32c-64 48-128 64-224 96 0 128 160 320 224 368 64-48 224-240 224-368-96-32-160-48-224-96zm0 34.75l5.4 4.05c49.7 37.3 99.6 49.9 176.7 75.6l6.2 2v6.5c0 55-33.1 119.7-72 176.4-38.9 56.8-83.6 105-110.9 125.5l-5.4 4.1-5.4-4.1c-27.3-20.5-72-68.7-110.9-125.5-38.9-56.7-72-121.4-72-176.4v-6.5l6.15-2C150.9 120.7 200.9 108 250.6 70.8l5.4-4.05zm0 22.18c-49.4 35.37-99.8 49.17-170.05 72.37 2.58 46.7 32.35 107 68.65 159.9 35.3 51.5 76.6 96.3 101.4 116.8 24.8-20.5 66.1-65.3 101.4-116.8 36.3-52.9 66.1-113.2 68.6-159.9-70.3-23.2-120.6-37-170-72.37zm-45.5 54.97c19.7.5 38.1 14.4 45.5 48.1 18-86.3 110-42.5 110 22.5-1 63.9-92 107.7-110 162.1-19-54.4-108-98.2-110-162.1 0-39.6 33.8-71.3 64.5-70.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
