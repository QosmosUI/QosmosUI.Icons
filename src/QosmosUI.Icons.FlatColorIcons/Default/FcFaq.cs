// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcFaq : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#558B2F");
		builder.AddAttribute(15, "d", "M15,40h23l6,6V25c0-2.2-1.8-4-4-4H15c-2.2,0-4,1.8-4,4v11C11,38.2,12.8,40,15,40z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#1B5E20");
		builder.AddAttribute(18, "d", "M28.8,32.8h-3.6l-0.7,2.1h-2.2l3.7-10h1.9l3.7,10h-2.2L28.8,32.8z M25.7,31.2h2.5L27,27.4L25.7,31.2z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#8BC34A");
		builder.AddAttribute(21, "d", "M33,25H10l-6,6V8c0-2.2,1.8-4,4-4h25c2.2,0,4,1.8,4,4v13C37,23.2,35.2,25,33,25z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#fff");
		builder.AddAttribute(24, "d", "M25.4,14.2c0,1-0.2,1.8-0.5,2.5c-0.3,0.7-0.7,1.3-1.3,1.7l1.7,1.3L24,20.9l-2.2-1.7c-0.2,0-0.5,0.1-0.8,0.1 c-0.6,0-1.2-0.1-1.8-0.3c-0.5-0.2-1-0.6-1.4-1c-0.4-0.4-0.7-1-0.9-1.6c-0.2-0.6-0.3-1.3-0.3-2.1v-0.4c0-0.8,0.1-1.5,0.3-2.1 c0.2-0.6,0.5-1.2,0.9-1.6c0.4-0.4,0.8-0.8,1.4-1c0.5-0.2,1.1-0.3,1.8-0.3c0.6,0,1.2,0.1,1.8,0.3c0.5,0.2,1,0.6,1.4,1 c0.4,0.4,0.7,1,0.9,1.6c0.2,0.6,0.3,1.3,0.3,2.1V14.2z M23.2,13.7c0-1.1-0.2-1.9-0.6-2.4c-0.4-0.6-0.9-0.8-1.6-0.8 c-0.7,0-1.3,0.3-1.6,0.8c-0.4,0.6-0.6,1.4-0.6,2.4v0.5c0,0.5,0.1,1,0.2,1.4c0.1,0.4,0.2,0.8,0.4,1c0.2,0.3,0.4,0.5,0.7,0.6 c0.3,0.1,0.6,0.2,0.9,0.2c0.7,0,1.3-0.3,1.6-0.8c0.4-0.6,0.6-1.4,0.6-2.5V13.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
