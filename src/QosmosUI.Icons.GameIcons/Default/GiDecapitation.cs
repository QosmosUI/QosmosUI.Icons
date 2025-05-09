// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDecapitation : ComponentBase
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
		builder.AddAttribute(14, "d", "M316.938 18.406c-16.917.16-35.992 8.394-51.344 23.813-25.855 25.966-31.416 62.47-12.438 81.53 18.978 19.06 55.332 13.468 81.188-12.5C360.2 85.282 365.76 48.78 346.78 29.72c-7.71-7.745-18.268-11.422-29.842-11.314zM26.125 33.344C68.1 93.84 134.52 136.714 204.188 163.874c.768.296 1.542.584 2.312.876 74.676 28.292 158.988 40.7 228.22 31.875.072-.013.144-.018.217-.03 73.4-13.258 89.237-60.577-38.562-134.25 163.392 147.973-242.187 125.144-370.25-29zM220.28 189.688c-3.947 2.137-7.548 4.605-10.874 7.375-12.204 10.163-20.78 24.71-26.75 42.187-10.988 32.16-12.56 73.362-13.375 109.563h40.064l.625 8.656 10.218 136.467h86.687l9.03-136.406.595-8.717h38.53c1.694-40.387-.062-81.073-12.25-111.594-3.295-8.256-7.23-15.796-12-22.5-36.92-4.4-74.495-12.92-110.5-25.032z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
