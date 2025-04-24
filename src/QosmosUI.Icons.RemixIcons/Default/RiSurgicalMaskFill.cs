// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSurgicalMaskFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.4851 3.12124L20.2425 5.0606C20.6877 5.1719 21 5.57188 21 6.03075V6.99952L22 6.99997C23.1 6.99997 24 7.89997 24 8.99997V12C24 13.6568 22.6569 15 21 15L20.5789 15.0003C20.0443 16.3501 19.0275 17.4862 17.6833 18.1583L12.8944 20.5528C12.3314 20.8343 11.6686 20.8343 11.1056 20.5528L6.31672 18.1583C4.97252 17.4862 3.95573 16.3501 3.42113 15.0003L3 15C1.34315 15 0 13.6568 0 12V8.99997C0 7.8954 0.89543 6.99997 2 6.99997L3 6.99952V6.03075C3 5.57188 3.3123 5.1719 3.75746 5.0606L11.5149 3.12124C11.8334 3.04162 12.1666 3.04162 12.4851 3.12124ZM3 8.99997H2V12C2 12.5523 2.44772 13 3 13V8.99997ZM22 8.99997H21V13C21.5523 13 22 12.5523 22 12V8.99997Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
