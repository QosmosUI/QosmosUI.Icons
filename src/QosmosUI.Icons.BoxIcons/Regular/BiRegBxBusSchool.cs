// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxBusSchool : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M21.259 11.948A.986.986 0 0 0 22 11V8a.999.999 0 0 0-.996-.999V6H21c0-2.206-1.794-4-4-4H7C4.794 2 3 3.794 3 6v1a1 1 0 0 0-1 1v3c0 .461.317.832.742.948a3.953 3.953 0 0 0-.741 2.298l.004 3.757c.001.733.404 1.369.995 1.716V21a1 1 0 0 0 1 1h1a1 1 0 0 0 1-1v-1h12v1a1 1 0 0 0 1 1h1a1 1 0 0 0 1-1v-1.274a2.02 2.02 0 0 0 .421-.313c.377-.378.585-.881.584-1.415l-.004-3.759a3.966 3.966 0 0 0-.742-2.291zM5 18h-.995l-.004-3.757c-.001-.459.161-.89.443-1.243h15.111c.283.353.445.783.446 1.242L20.006 18H5zm6.004-10v3H5V8h6.004zM19 11h-5.996V8H19v3zM7 4h10c1.103 0 2 .897 2 2h-4V5H9v1H5c0-1.103.897-2 2-2z");
		builder.CloseElement();
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "6.5");
		builder.AddAttribute(17, "cy", "15.5");
		builder.AddAttribute(18, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "17.5");
		builder.AddAttribute(21, "cy", "15.5");
		builder.AddAttribute(22, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
