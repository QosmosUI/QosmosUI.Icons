// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSteeringLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M21.7992 14.001C20.9633 18.1168 17.5995 21.3145 13.399 21.9028L13.3992 19.878C16.4926 19.3321 18.9729 17.0086 19.7473 14.0004L21.7992 14.001ZM4.25157 14.0004C5.01757 16.9759 7.45244 19.2814 10.4989 19.8595V21.8882C6.3456 21.2632 3.02888 18.0838 2.19968 14.001L4.25157 14.0004ZM17.9994 11V13H14.9994C13.9451 13 13.0813 13.8159 13.0049 14.8507L12.9994 15V18H10.9994V15C10.9994 13.9456 10.1836 13.0818 9.14871 13.0055L8.99944 13H5.99944V11H17.9994ZM11.9994 2C17.1848 2 21.4483 5.94662 21.9501 10.9999L19.9376 11C19.4455 7.05371 16.0791 4 11.9994 4C7.91981 4 4.55341 7.05371 4.06133 11L2.04883 10.9999C2.5506 5.94662 6.81413 2 11.9994 2Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
