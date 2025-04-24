// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBackstab : ComponentBase
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
		builder.AddAttribute(14, "d", "M180.75 22.97l-17.72 5.968 25.345 75.406 17.72-6.03-25.345-75.345zm73.906 78.56L149.97 137.157l10.155 29.875c8.316-9.75 17.78-17.498 28.125-23.374 7.232 27.494 16.666 54.12 27.813 79.906 13-5.56 26.423-10.197 39.906-13.718-6.967-26.727-15.822-53.187-26.345-79.313 11.295-1.24 23.1-.91 35.22.94l-10.19-29.94zm191.688 88.22c-19.464-.103-42.28 9.843-60.875 28.438-5.778 5.776-10.684 11.978-14.75 18.343-28.734-17.313-69.766-18.263-110.22-7.968-.02-.093-.04-.187-.063-.28-12.357 3.134-24.726 7.248-36.687 12.312l.188.406c-87.328 37.506-151.902 123.99-48.032 202.063H46.03L17.25 495.03h279.875l-96.28-112.374c26.414-29.067 73.41-47.584 105.56-49.062C321.42 382.674 345.85 457.11 384.47 495h66.25c-46.88-50.664-83.318-118.734-89.19-195.75 1.76 3.523 4.022 6.77 6.845 9.594 20.312 20.312 60.906 12.657 90.656-17.094 29.752-29.75 37.407-70.344 17.095-90.656-7.617-7.617-18.103-11.282-29.78-11.344z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
