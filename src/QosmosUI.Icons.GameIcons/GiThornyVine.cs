// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiThornyVine : ComponentBase
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
		builder.AddAttribute(14, "d", "M170.03 19.97c-9.84-.048-20.1 1.433-30.468 4.718 35.302 10.096 48.28 38.273 28.313 50.874-19.99 4.045-38.712 10.416-55.438 19.5-29.128-24.24-76.94-16.207-98.374 27.126 25.322-15.383 53.47-5.423 51.062 13.406-4.616 6.22-8.8 12.928-12.47 20.156C29.29 201.79 22.633 246.438 32 283.188c9.368 36.75 34.264 66.22 77.313 83.375 31.047 12.37 67.714 6.876 92.437-10.47 17.063-11.97 28.697-28.66 29.97-49.843-5.095 7.016-11.27 12.66-18.25 16.656-15.738 9.01-34.5 10.306-51.94 5.97-17.438-4.338-33.843-14.324-45.186-29.063-11.344-14.74-17.314-34.496-13.406-56.47 7.892-44.383 43.592-73.596 83.25-80.343 39.657-6.747 84.25 9.094 109.312 52.5 18.92 32.77 19.77 66.857 8.156 97.406-11.614 30.55-35.028 57.797-64.187 80.25-48.663 37.47-125.09 46.22-216.532 19.72v81.5H357c7.82-5.284 14.934-10.99 21.406-17.063 51.168 12.833 106.224-25.224 118.188-93.594-27.192 29.037-59.208 30.884-70.125 11.78 1.63-5.822 3.052-11.756 4.25-17.78 5.384-27.102 6.4-56.04 4.53-85.033 48.266-16.233 70.995-76.93 42.03-138.656-5.8 43.27-40.027 61.433-60.06 41-7.794-19.842-18.865-37.928-32.408-53.81 17.286-40.49-7.463-92.795-64.687-116.22 23.025 31.505 16.59 61.334-6.594 62.906-21.08-9.474-43.803-15.414-67.124-17.156-10.18-29.884-40.52-50.61-76.375-50.78z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
