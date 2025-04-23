// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiThornedArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.03 19.875v19L75.657 95.5l-48.47 28.125 86.658 12.47-46.938 27.25 88.063 12.686-47.69 27.69 89.5 12.905 3.407 3.406-48.468 28.095 88.124 12.688-47.75 27.718 89.47 12.876.06.063.032-.032 23.125 3.312-28.718 28.72c31.304 19.57 71.2 39.18 100.594 46.874-7.61-31.554-26.336-68.222-46.906-100.563l-15.614 15.208c-16.25-17.246-.464-.61-19.855-20.863l-14.843-103.22-27.718 47.75-12.69-88.124-30.436 52.5-13.97-96.936-27.718 47.75L154.22 45.72l-32.44 55.905-81.75-81.75zM390.47 185.47l-8.064 36.81c35.057 67.22 63.472 144.408 63.47 215.47v9.344h-9.345c-62.652 0-144.955-28.477-211.78-61.906l-43.5 9.53c89.616 51.746 220.718 102.597 311.813 102.594.005-102.37-48.425-218.022-102.594-311.843zm-14.44 65.905l-11.155 50.906c16.02 29.348 28.89 60.25 32.906 88.72l1.75 12.313-12.31-1.75c-25.628-3.615-57.698-16.82-87.658-32.75l-44.875 9.812c57.178 26.034 122.48 46.993 172.22 49.47-2.193-56.77-23.28-119.44-50.876-176.72z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
