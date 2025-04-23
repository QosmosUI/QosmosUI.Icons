// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiNothingToSay : ComponentBase
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
		builder.AddAttribute(14, "d", "M254.156 56.938c-64.144 0-122.393 19.17-165.03 50.718-42.64 31.547-69.845 76.01-69.845 125.5 0 49.492 27.207 93.952 69.845 125.5 6.388 4.727 13.13 9.164 20.188 13.313l-12.657 95.905 90.594-65.75c21.226 4.708 43.67 7.25 66.906 7.25 64.144 0 122.362-19.17 165-50.72C461.794 327.11 489 282.65 489 233.156c0-49.49-27.206-93.95-69.844-125.5-42.638-31.546-100.856-50.718-165-50.718zM157 274.438c12.69 0 23 10.276 23 22.968 0 12.69-10.31 23-23 23s-22.97-10.31-22.97-23 10.28-22.97 22.97-22.97zm96.844 0c12.69 0 22.97 10.276 22.97 22.968-.002 12.69-10.28 23-22.97 23s-23-10.31-23-23 10.31-22.97 23-22.97zm99.844 0c12.69 0 22.968 10.276 22.968 22.968 0 12.69-10.278 23-22.97 23-12.69 0-22.998-10.31-22.998-23s10.31-22.97 23-22.97z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
