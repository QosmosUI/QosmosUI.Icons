// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWheniwork : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 24C5.342 24 0 18.582 0 12 0 5.342 5.342 0 12 0s12 5.342 12 12c0 6.582-5.342 12-12 12zm0-21.986c-5.497 0-9.987 4.489-9.987 9.986 0 5.498 4.49 9.988 9.987 9.988 5.498 0 9.987-4.49 9.987-9.988 0-5.497-4.489-9.986-9.987-9.986zm5.885 11.148H9.213c-.384 0-.695-.309-.698-.691v-1.012c0-.387.311-.697.698-.697h8.748c.387 0 .697.311.697.697v1.006c-.077.387-.387.697-.773.697zm-2.246-3.871H6.891c-.383.002-.697-.307-.698-.691V7.59c0-.311.31-.621.697-.621h8.748c.31 0 .62.311.62.619v1.006c.001.386-.31.697-.619.697zm-8.748 5.418h8.748c.388 0 .696.311.696.697v1.006c.002.383-.309.695-.691.697H6.891c-.388-.076-.697-.387-.697-.773V15.33c-.001-.31.309-.621.697-.621z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
