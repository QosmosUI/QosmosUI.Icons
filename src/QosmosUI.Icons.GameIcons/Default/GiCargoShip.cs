// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCargoShip : ComponentBase
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
		builder.AddAttribute(14, "d", "M80 23v18h23v14h18V41h23V23zm-8.2 50L42.38 279H135V144.5H95.5v-49H135V73zM185 137v46h78v-46zm96 0v46h78v-46zm96 0v46h78v-46zm-192 64v46h78v-46zm96 0v46h78v-46zm96 0v46h78v-46zm-192 64v46h78v-46zm96 0v46h19.3l32-32H359v-14zm96 0v14h78v-14zM27.22 297l24.11 108.5C76.75 398.1 105.7 391 128 391c24.2 0 46.2 8.6 67.2 16.6 21 8 41 15.4 60.8 15.4 19.8 0 39.8-7.4 60.8-15.4 19-7.2 38.9-15 60.5-16.4l-44.1-14.7 5.6-17 36.2 12V345h-17v-18h17v-30h-35.3l-32 32H154.4l-16-32zM393 297v30h17v18h-17v26.5l36.2-12 5.6 17-44 14.7c12.1.7 25.7 3.1 39.4 6.2 5.4-7.1 10.8-15.3 16.1-24 14.9-24.9 28.2-53.9 36.8-76.4zM128 407c-24.2 0-56.26 8.3-83.09 16.4-10.02 3-19.26 6-26.91 8.7v19c8.36-3 19.57-6.7 32.11-10.5C76.28 432.7 108.2 425 128 425c19.8 0 39.8 7.4 60.8 15.4s43 16.6 67.2 16.6c24.2 0 46.2-8.6 67.2-16.6 21-8 41-15.4 60.8-15.4 19.8 0 51.7 7.7 77.9 15.6 12.5 3.8 23.7 7.5 32.1 10.5v-19c-7.7-2.6-16.9-5.7-26.9-8.7-26.8-8.1-58.9-16.4-83.1-16.4-24.2 0-46.2 8.6-67.2 16.6-21 8-41 15.4-60.8 15.4-19.8 0-39.8-7.4-60.8-15.4S152.2 407 128 407zm0 36c-24.2 0-56.26 8.3-83.09 16.4-10.02 3-19.26 6-26.91 8.7v19c8.36-3 19.57-6.7 32.11-10.5C76.28 468.7 108.2 461 128 461c19.8 0 39.8 7.4 60.8 15.4s43 16.6 67.2 16.6c24.2 0 46.2-8.6 67.2-16.6 21-8 41-15.4 60.8-15.4 19.8 0 51.7 7.7 77.9 15.6 12.5 3.8 23.7 7.5 32.1 10.5v-19c-7.7-2.6-16.9-5.7-26.9-8.7-26.8-8.1-58.9-16.4-83.1-16.4-24.2 0-46.2 8.6-67.2 16.6-21 8-41 15.4-60.8 15.4-19.8 0-39.8-7.4-60.8-15.4S152.2 443 128 443z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
