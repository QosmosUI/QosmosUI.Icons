// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiArrowhead : ComponentBase
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
		builder.AddAttribute(14, "d", "M34.22 19.844l-12.407.125.062 30 177.97 177.5c4.98-8.957 12.884-16.088 22.405-20.064L34.22 19.844zm205.436 202.75c-14.946 0-26.844 11.93-26.844 26.875s11.898 26.874 26.844 26.874c14.946 0 26.875-11.93 26.875-26.875 0-14.947-11.928-26.876-26.874-26.876zm150.875 15.75c-15.905 11.413-31.637 18.404-47.467 21.5 29.263 39.57 49.927 71.443 62.28 96 6.804 13.523 11.162 24.788 12.907 34.562 1.745 9.774.876 19.417-5.813 25.906-6.688 6.49-16.216 7.208-26.125 5.532-9.908-1.676-21.394-5.88-35.187-12.438-25.368-12.058-58.377-32.294-99.22-60.906-2.646 16.347-8.904 32.21-19.06 47.53 64.07 43.58 163.496 83.783 246.468 88.783 3.614-85.247-42.328-181.024-88.782-246.47zm-105.655 16.562c-2.375 19.668-17.412 35.58-36.656 39.28 3.07 11 4.776 21.816 5.093 32.44 44.728 31.797 80.314 53.785 105.812 65.905 12.888 6.127 23.263 9.684 30.313 10.876 7.05 1.193 9.577-.12 9.968-.5.392-.38 1.644-2.46.438-9.22-1.207-6.756-4.852-16.84-11.188-29.436-12.4-24.647-34.88-59.106-67.5-102.563-11.922-.288-23.968-2.61-36.28-6.78z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
