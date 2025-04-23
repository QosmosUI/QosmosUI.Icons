// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiRetroController : ComponentBase
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
		builder.AddAttribute(14, "d", "M389.094 253.12H122.962a101.945 101.945 0 1 0 89.208 151.258h87.66a101.945 101.945 0 1 0 89.264-151.258zM165.69 362.62h-30.137v30.138h-31.618V362.62h-30.14v-31.618h30.13v-30.128h31.617v30.128h30.15v31.618zm190.996 7.136a17.932 17.932 0 1 1 17.91-17.932 17.932 17.932 0 0 1-17.92 17.932zm40.922 40.923a17.932 17.932 0 1 1 17.92-17.922 17.932 17.932 0 0 1-17.93 17.92zm0-81.858a17.932 17.932 0 1 1 17.932-17.932 17.932 17.932 0 0 1-17.943 17.944zm40.923 40.923a17.932 17.932 0 1 1 17.933-17.932 17.932 17.932 0 0 1-17.932 17.943zM260.546 18.99h19.603c3.986 10.57 5.16 20.326 3.512 29.235-4.043 22.392-24.052 35.367-43.44 47.912-21.625 14.025-42.04 27.282-40.472 52.204 1.694 26.9 18.407 40.89 36.135 55.705 10.682 8.943 21.997 18.417 29.36 31.008h-22.2c-5.218-5.816-11.688-11.292-18.746-17.153-18.914-15.81-40.346-33.786-42.537-68.42-2.258-35.467 24.843-53.015 48.67-68.497 16.88-10.942 32.814-21.342 35.513-36.02 1.377-7.34-.407-15.923-5.398-25.973z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
