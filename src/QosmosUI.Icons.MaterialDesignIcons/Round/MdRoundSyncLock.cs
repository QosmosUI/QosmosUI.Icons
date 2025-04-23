// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSyncLock : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M10,19c0,0.55-0.45,1-1,1H5c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h1.73C5.06,16.54,4,14.4,4,12 c0-3.19,1.87-5.93,4.56-7.22C9.23,4.47,10,4.96,10,5.7c0,0.38-0.22,0.72-0.57,0.88C7.41,7.55,6,9.61,6,12c0,1.77,0.78,3.34,2,4.44 V15c0-0.55,0.45-1,1-1h0c0.55,0,1,0.45,1,1V19z M15,4c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V7.56 c1.22,1.1,2,2.67,2,4.44h2c0-2.4-1.06-4.54-2.73-6H19c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H15z M20,17v-1c0-1.1-0.9-2-2-2 s-2,0.9-2,2v1c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-3C21,17.45,20.55,17,20,17z M19,17h-2v-1 c0-0.55,0.45-1,1-1s1,0.45,1,1V17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
