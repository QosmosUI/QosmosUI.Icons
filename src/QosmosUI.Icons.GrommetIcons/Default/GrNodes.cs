// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrNodes : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M14,4 C14,5.1048 13.1048,6 12,6 C10.8952,6 10,5.1048 10,4 C10,2.8952 10.8952,2 12,2 C13.1048,2 14,2.8952 14,4 Z M14,20 C14,21.1048 13.1048,22 12,22 C10.8952,22 10,21.1048 10,20 C10,18.8952 10.8952,18 12,18 C13.1048,18 14,18.8952 14,20 Z M7,8 C7,9.1048 6.1048,10 5,10 C3.8952,10 3,9.1048 3,8 C3,6.8952 3.8952,6 5,6 C6.1048,6 7,6.8952 7,8 Z M7,16 C7,17.1048 6.1048,18 5,18 C3.8952,18 3,17.1048 3,16 C3,14.8952 3.8952,14 5,14 C6.1048,14 7,14.8952 7,16 Z M21,8 C21,9.1048 20.1048,10 19,10 C17.8952,10 17,9.1048 17,8 C17,6.8952 17.8952,6 19,6 C20.1048,6 21,6.8952 21,8 Z M21,16 C21,17.1048 20.1048,18 19,18 C17.8952,18 17,17.1048 17,16 C17,14.8952 17.8952,14 19,14 C20.1048,14 21,14.8952 21,16 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
