// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDeveloperBoard : ComponentBase
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
		builder.AddAttribute(14, "d", "M22 8c0-.55-.45-1-1-1h-1V5c0-1.1-.9-2-2-2H4c-1.1 0-2 .9-2 2v14c0 1.1.9 2 2 2h14c1.1 0 2-.9 2-2v-2h1c.55 0 1-.45 1-1s-.45-1-1-1h-1v-2h1c.55 0 1-.45 1-1s-.45-1-1-1h-1V9h1c.55 0 1-.45 1-1zm-5 11H5c-.55 0-1-.45-1-1V6c0-.55.45-1 1-1h12c.55 0 1 .45 1 1v12c0 .55-.45 1-1 1zM6.5 13h4c.28 0 .5.22.5.5v3c0 .28-.22.5-.5.5h-4c-.28 0-.5-.22-.5-.5v-3c0-.28.22-.5.5-.5zm6-6h3c.28 0 .5.22.5.5v2c0 .28-.22.5-.5.5h-3c-.28 0-.5-.22-.5-.5v-2c0-.28.22-.5.5-.5zm-6 0h4c.28 0 .5.22.5.5v4c0 .28-.22.5-.5.5h-4c-.28 0-.5-.22-.5-.5v-4c0-.28.22-.5.5-.5zm6 4h3c.28 0 .5.22.5.5v5c0 .28-.22.5-.5.5h-3c-.28 0-.5-.22-.5-.5v-5c0-.28.22-.5.5-.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
