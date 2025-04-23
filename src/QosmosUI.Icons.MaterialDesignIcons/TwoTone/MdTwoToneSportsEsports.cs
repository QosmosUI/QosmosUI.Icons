// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSportsEsports : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M16.53,7H7.47C6.48,7,5.63,7.74,5.49,8.72L4.4,16.37c-0.03,0.21,0.05,0.35,0.13,0.44 C4.6,16.9,4.73,17,4.94,17c0.15,0,0.29-0.06,0.39-0.16L8.17,14h7.66l2.84,2.84c0.1,0.1,0.24,0.16,0.39,0.16 c0.21,0,0.34-0.1,0.42-0.19c0.08-0.09,0.16-0.23,0.13-0.44l-1.09-7.66C18.37,7.74,17.52,7,16.53,7z M11,11H9v2H8v-2H6v-1h2V8h1v2 h2V11z M15,10c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C16,9.55,15.55,10,15,10z M17,13c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1s1,0.45,1,1C18,12.55,17.55,13,17,13z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M21.58,16.09l-1.09-7.66C20.21,6.46,18.52,5,16.53,5H7.47C5.48,5,3.79,6.46,3.51,8.43l-1.09,7.66 C2.2,17.63,3.39,19,4.94,19h0c0.68,0,1.32-0.27,1.8-0.75L9,16h6l2.25,2.25c0.48,0.48,1.13,0.75,1.8,0.75h0 C20.61,19,21.8,17.63,21.58,16.09z M19.48,16.81C19.4,16.9,19.27,17,19.06,17c-0.15,0-0.29-0.06-0.39-0.16L15.83,14H8.17 l-2.84,2.84C5.23,16.94,5.09,17,4.94,17c-0.21,0-0.34-0.1-0.42-0.19c-0.08-0.09-0.16-0.23-0.13-0.44l1.09-7.66 C5.63,7.74,6.48,7,7.47,7h9.06c0.99,0,1.84,0.74,1.98,1.72l1.09,7.66C19.63,16.58,19.55,16.72,19.48,16.81z");
		builder.CloseElement();
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "points", "9,8 8,8 8,10 6,10 6,11 8,11 8,13 9,13 9,11 11,11 11,10 9,10");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "17");
		builder.AddAttribute(29, "cy", "12");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "15");
		builder.AddAttribute(33, "cy", "9");
		builder.AddAttribute(34, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
