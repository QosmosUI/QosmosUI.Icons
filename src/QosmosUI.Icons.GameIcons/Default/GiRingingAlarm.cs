// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRingingAlarm : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 41c-89.577 0-162 72.423-162 162s72.423 162 162 162 162-72.423 162-162S345.577 41 256 41zm151.883 9.932l-12.248 13.19c42.18 39.167 52.373 78.107 55.332 118.46l17.951-1.316c-3.13-42.694-15.447-88.002-61.035-130.334zm49.334.504l-13.16 12.279c16.636 17.828 28.995 43.23 32.785 64.402l17.719-3.172c-4.514-25.216-18.03-52.81-37.344-73.51zM256 158c27.401 0 50 22.599 50 50s-22.599 50-50 50-50-22.599-50-50 22.599-50 50-50zm0 36c-7.945 0-14 6.055-14 14s6.055 14 14 14 14-6.055 14-14-6.055-14-14-14zM61.19 219.252l-17.952 1.316c3.13 42.694 15.447 88.004 61.035 130.336l12.248-13.191c-42.18-39.168-52.373-78.108-55.332-118.461zm396.197 43.543c-13.7 0-25 11.3-25 25 0 12.561 9.5 23.097 21.638 24.764 7.8 43.445-6.374 94.946-45.025 131.992v23.86c52.635-41.742 72.756-105.706 62.557-160.083 6.52-4.534 10.83-12.074 10.83-20.533 0-13.7-11.3-25-25-25zM35.314 273.719l-17.716 3.172c4.513 25.216 18.027 52.81 37.341 73.51l13.16-12.282c-16.636-17.828-28.995-43.228-32.785-64.4zM137 337.965V407h238v-69.035C343.26 365.979 301.595 383 256 383s-87.26-17.021-119-45.035zM121 425v68h270v-68H121z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
