// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTranscribe : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "9");
		builder.AddAttribute(22, "cy", "9");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "r", "2");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M14.48,17.34C13.29,16.73,11.37,16,9,16c-2.37,0-4.29,0.73-5.48,1.34C3.2,17.5,3,17.84,3,18.22V19h12v-0.78 C15,17.84,14.8,17.5,14.48,17.34z");
		builder.AddAttribute(27, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M17.93,2c-3.9,3.89-3.91,9.95,0,14l1.63-1.63c-2.77-3.02-2.77-7.56,0-10.74L17.93,2z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M9,13c2.21,0,4-1.79,4-4c0-2.21-1.79-4-4-4S5,6.79,5,9C5,11.21,6.79,13,9,13z M9,7c1.1,0,2,0.9,2,2c0,1.1-0.9,2-2,2 s-2-0.9-2-2C7,7.9,7.9,7,9,7z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M15.39,15.56C13.71,14.7,11.53,14,9,14c-2.53,0-4.71,0.7-6.39,1.56C1.61,16.07,1,17.1,1,18.22V21h16v-2.78 C17,17.1,16.39,16.07,15.39,15.56z M15,19H3v-0.78c0-0.38,0.2-0.72,0.52-0.88C4.71,16.73,6.63,16,9,16c2.37,0,4.29,0.73,5.48,1.34 C14.8,17.5,15,17.84,15,18.22V19z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M22.92,7.06l-1.68-1.69c-2.02,2.02-2.02,5.07,0,7.27l1.68-1.69C22.08,9.77,22.08,8.24,22.92,7.06z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
