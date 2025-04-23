// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpAppSettingsAlt : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M21.81,12.74l-0.82-0.63c0-0.09,0-0.13,0-0.22l0.8-0.63c0.16-0.12,0.2-0.34,0.1-0.51l-0.85-1.48 c-0.07-0.13-0.21-0.2-0.35-0.2c-0.05,0-0.1,0.01-0.15,0.03l-0.95,0.38c-0.08-0.05-0.11-0.07-0.19-0.11l-0.15-1.01 C19.22,8.15,19.05,8,18.85,8h-1.71c-0.2,0-0.37,0.15-0.4,0.34L16.6,9.35c-0.03,0.02-0.07,0.03-0.1,0.05 c-0.03,0.02-0.06,0.04-0.09,0.06l-0.95-0.38c-0.05-0.02-0.1-0.03-0.15-0.03c-0.14,0-0.27,0.07-0.35,0.2l-0.85,1.48 c-0.1,0.17-0.06,0.39,0.1,0.51l0.8,0.63c0,0.09,0,0.13,0,0.23l-0.8,0.63c-0.16,0.12-0.2,0.34-0.1,0.51l0.85,1.48 c0.07,0.13,0.21,0.2,0.35,0.2c0.05,0,0.1-0.01,0.15-0.03l0.95-0.37c0.08,0.05,0.12,0.07,0.2,0.11l0.15,1.01 c0.03,0.2,0.2,0.34,0.4,0.34h1.71c0.2,0,0.37-0.15,0.4-0.34l0.15-1.01c0.03-0.02,0.07-0.03,0.1-0.05c0.03-0.02,0.06-0.04,0.09-0.06 l0.95,0.38c0.05,0.02,0.1,0.03,0.15,0.03c0.14,0,0.27-0.07,0.35-0.2l0.85-1.48C22.01,13.08,21.97,12.86,21.81,12.74z M18,13.5 c-0.83,0-1.5-0.67-1.5-1.5c0-0.83,0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5C19.5,12.83,18.83,13.5,18,13.5z M5,23V1h14v6h-2V6H7v12h10v-1 h2v6H5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
