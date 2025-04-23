// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTorch : ComponentBase
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
		builder.AddAttribute(14, "d", "M476.72 51.375c-5.28 30.185-124.992 107.9-82.47 16.875-80.216 45.38-107.557 23.42-78.53-5.656-54.825 2.8-62.753 88.173-55.345 112.406l17.438 19.125c-2.14-31.218.404-48.445 19.5-71.47 13.764 20.614 18.495 33.702 52.062 6.97-9.393 53.52 54.61 18.747 88.75 10.938-15.248 14.048-35.153 32.723-38.875 55.468-1.24 7.587 6.208 17.925 14.125 25.626-9.443 2.236-41.474 8.91-38.563 26.22 2.912 17.31 12.14 11.885 3.5 15.28-12.403 2.766-21.156 5.58-39.593-2.187l18.874 20.717c28.39 14.79 73.904 7.306 83.594-14.875-14.778-1.22-27.125-4.674-33-11.53 44.022-8.34 66.764-39.243 85.78-75.032-33.638 18.95-42.158 17.784-56 16.313 35.514-14.365 46.876-108.943 38.75-145.188zM246.874 186.063l-56.78 70.125 79.186 86.906 75.095-50-97.5-107.03zm-62.344 90.125L21.657 467.625l21.438 23.53 205.75-144.374-64.313-70.592z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
