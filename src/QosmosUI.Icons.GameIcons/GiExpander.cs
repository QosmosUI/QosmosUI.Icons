// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiExpander : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.625 16c-1.74.052-2.956.394-3.594 1.03-10.2 10.203 58.65 170.85 76.5 178.5 5.02 2.152 15.865-3.563 28.72-13.28h.03L196 256l-73.72 73.75c-12.863-9.726-23.728-15.433-28.75-13.28-17.85 7.65-86.7 168.297-76.5 178.5 10.203 10.2 170.85-58.65 178.5-76.5 2.153-5.022-3.554-15.887-13.28-28.75L256 316l73.75 73.75c-9.717 12.855-15.432 23.7-13.28 28.72 7.65 17.85 168.297 86.7 178.5 76.5 10.2-10.203-58.65-170.85-76.5-178.5-5.02-2.152-15.865 3.563-28.72 13.28L316 256l73.75-73.75c12.855 9.717 23.7 15.432 28.72 13.28 17.85-7.65 86.7-168.297 76.5-178.5-10.203-10.2-170.85 58.65-178.5 76.5-2.153 5.022 3.554 15.887 13.28 28.75L256 196l-73.75-73.72c.005-.006-.005-.023 0-.03 9.717-12.855 15.432-23.7 13.28-28.72C188.36 76.796 46.71 15.225 20.626 16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
