// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiInterdiction : ComponentBase
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
		builder.AddAttribute(14, "d", "M256.22 24.594C174.977 24.444 95.923 66.54 52.374 141.97c-64.817 112.266-26.36 255.744 85.906 320.56 112.268 64.818 255.747 26.362 320.564-85.905 64.817-112.267 26.36-255.745-85.906-320.563-36.838-21.268-77.044-31.395-116.72-31.468zm-.126 45.562c31.98.056 64.38 8.237 94.062 25.375 82.963 47.9 115.894 149.142 80.5 235.376L184 84.25c22.816-9.31 47.322-14.137 72.094-14.094zm-117.125 40.22l265.53 265.53c-9.55 12.227-20.382 23.04-32.22 32.313L106.69 142.624c9.556-12.224 20.435-22.984 32.28-32.25zm-58.407 77.28L327.25 434.344c-52.287 21.37-113.55 19.208-166.25-11.22-82.987-47.912-115.88-149.212-80.438-235.468z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
