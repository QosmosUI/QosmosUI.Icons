// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundUnsubscribe : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M18.5 11.5c.92 0 1.75.26 2.49.69V5c0-1.1-.89-2-1.99-2H5c-1.1 0-2 .9-2 2v10c0 1.1.9 2 2 2h8.55c-.02-.17-.05-.33-.05-.5 0-2.76 2.24-5 5-5zm-5.61-1.45c-.56.28-1.23.28-1.79 0l-5.61-2.8c-.3-.15-.49-.46-.49-.8 0-.66.7-1.1 1.29-.8L12 8.5l5.71-2.85c.59-.3 1.29.13 1.29.8 0 .34-.19.65-.49.8l-5.62 2.8zM18.5 13c-1.93 0-3.5 1.57-3.5 3.5s1.57 3.5 3.5 3.5 3.5-1.57 3.5-3.5-1.57-3.5-3.5-3.5zm2 3.5c0 .28-.22.5-.5.5h-3c-.28 0-.5-.22-.5-.5s.22-.5.5-.5h3c.28 0 .5.22.5.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
