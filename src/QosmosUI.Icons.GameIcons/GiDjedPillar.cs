// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDjedPillar : ComponentBase
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
		builder.AddAttribute(14, "d", "M215.6 25l-3.5 21H144v18h224V46h-68.1l-3.5-21h-80.8zm-34.4 55c2.8 3.14 5.5 6.32 8 9.6 4.7 6.29 8.7 13 10.5 20.4h112.6c1.8-7.4 5.8-14.11 10.5-20.4 2.5-3.28 5.2-6.46 8-9.6H181.2zM144 126v18h224v-18H144zm37.2 34c2.8 3.1 5.5 6.3 8 9.6 4.7 6.3 8.7 13 10.5 20.4h112.6c1.8-7.4 5.8-14.1 10.5-20.4 2.5-3.3 5.2-6.5 8-9.6H181.2zM144 206v18h224v-18H144zm37.2 34c2.8 3.1 5.5 6.3 8 9.6 4.7 6.3 8.7 13 10.5 20.4h112.6c1.8-7.4 5.8-14.1 10.5-20.4 2.5-3.3 5.2-6.5 8-9.6H181.2zM144 286v18h224v-18H144zm37.2 34c2.8 3.1 5.5 6.3 8 9.6 4.7 6.3 8.7 13 10.5 20.4h112.6c1.8-7.4 5.8-14.1 10.5-20.4 2.5-3.3 5.2-6.5 8-9.6H181.2zm19.8 48v16c0 19-8.8 39.9-21.3 60.6-8.8 14.8-19.7 29.3-31.1 42.4h214.8c-11.4-13.1-22.3-27.6-31.1-42.4C319.8 423.9 311 403 311 384v-16H201z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
