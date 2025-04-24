// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiGlass : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Glass");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18.279,2.54a1.475,1.475,0,0,0-1.1-.48H6.819a1.47,1.47,0,0,0-1.09.48,1.5,1.5,0,0,0-.41,1.12L6.379,19.6a2.51,2.51,0,0,0,2.49,2.34h6.26a2.519,2.519,0,0,0,2.5-2.34l1.05-15.94A1.5,1.5,0,0,0,18.279,2.54Zm-1.65,16.99a1.508,1.508,0,0,1-1.5,1.41H8.869a1.506,1.506,0,0,1-1.49-1.41l-.64-9.62a2.981,2.981,0,0,0,1.17-.49,1.828,1.828,0,0,1,1.18-.39,1.858,1.858,0,0,1,1.19.39,3.025,3.025,0,0,0,3.45,0,1.879,1.879,0,0,1,1.19-.39,1.828,1.828,0,0,1,1.18.39,3,3,0,0,0,1.16.49Zm.7-10.62a2.317,2.317,0,0,1-.69-.33,2.98,2.98,0,0,0-3.45,0,1.885,1.885,0,0,1-1.18.38,1.939,1.939,0,0,1-1.19-.38,2.818,2.818,0,0,0-1.73-.55,2.809,2.809,0,0,0-1.72.55,2.374,2.374,0,0,1-.7.33l-.35-5.32a.468.468,0,0,1,.14-.37.484.484,0,0,1,.36-.16h10.36a.523.523,0,0,1,.37.16.46.46,0,0,1,.13.37Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
