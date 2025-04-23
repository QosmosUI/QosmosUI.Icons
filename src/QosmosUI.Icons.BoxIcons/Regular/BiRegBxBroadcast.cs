// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxBroadcast : ComponentBase
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
		builder.AddAttribute(14, "d", "m19.707 4.293-1.414 1.414c2.733 2.733 2.733 7.353 0 10.086l1.414 1.414c3.5-3.5 3.5-9.414 0-12.914zm-4.414 4.414c.566.566.879 1.292.879 2.043s-.313 1.477-.879 2.043l1.414 1.414c.944-.943 1.465-2.172 1.465-3.457s-.521-2.514-1.465-3.457l-1.414 1.414zm-9.086-3L4.793 4.293c-3.5 3.5-3.5 9.414 0 12.914l1.414-1.414c-2.733-2.733-2.733-7.353 0-10.086z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M7.293 7.293c-.944.943-1.465 2.172-1.465 3.457s.521 2.514 1.465 3.457l1.414-1.414c-.566-.566-.879-1.292-.879-2.043s.313-1.477.879-2.043L7.293 7.293zM14 10.5a2 2 0 0 0-4 0 1.993 1.993 0 0 0 .895 1.666L10.002 22h3.996l-.893-9.835c.54-.358.895-.97.895-1.665z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
