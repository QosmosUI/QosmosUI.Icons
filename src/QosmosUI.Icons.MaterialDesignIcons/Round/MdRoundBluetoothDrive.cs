// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBluetoothDrive : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19.85,6l1.8-1.8c0.2-0.2,0.2-0.51,0-0.71L19.5,1.36c-0.32-0.31-0.85-0.09-0.85,0.35v3.08L16.7,2.85 c-0.19-0.19-0.51-0.19-0.7,0c-0.19,0.19-0.19,0.51,0,0.7L18.44,6L16,8.44c-0.19,0.19-0.19,0.5,0,0.7l0,0c0.19,0.2,0.51,0.2,0.7,0 l1.95-1.95v3.09c0,0.45,0.54,0.67,0.85,0.35l2.14-2.15c0.2-0.2,0.19-0.51,0-0.71L19.85,6z M19.65,2.91l0.94,0.94l-0.94,0.94V2.91z M19.65,9.08V7.2l0.94,0.94L19.65,9.08z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M15,10H4.81l1.04-3H15V5H5.5C4.84,5,4.29,5.42,4.08,6.01L2,12v7.5C2,20.33,2.67,21,3.5,21S5,20.33,5,19.5V19h12v0.5 c0,0.83,0.67,1.5,1.5,1.5s1.5-0.67,1.5-1.5V12h-3C15.9,12,15,11.1,15,10z M6.5,16C5.67,16,5,15.33,5,14.5S5.67,13,6.5,13 S8,13.67,8,14.5S7.33,16,6.5,16z M15.5,16c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S16.33,16,15.5,16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
