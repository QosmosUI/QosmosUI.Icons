// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiLineHeight : ComponentBase
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
		builder.AddAttribute(14, "id", "Line_Height");
		builder.AddAttribute(15, "data-name", "Line Height");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.439,4.062h-9a.5.5,0,1,1,0-1h9a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20.439,9.686h-9a.5.5,0,0,1,0-1h9a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20.439,15.31h-9a.5.5,0,0,1,0-1h9a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20.439,20.934h-9a.5.5,0,0,1,0-1h9a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M3.208,18.8a.5.5,0,0,1,.71-.71l1.14,1.14V4.775l-1.14,1.14a.513.513,0,0,1-.71,0,.5.5,0,0,1,0-.71l2-2a.494.494,0,0,1,.34-.14.549.549,0,0,1,.37.14l2,2a.524.524,0,0,1,0,.71.5.5,0,0,1-.71,0l-1.15-1.15v14.47l1.15-1.15a.5.5,0,1,1,.71.71l-2,2a.513.513,0,0,1-.71,0Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
