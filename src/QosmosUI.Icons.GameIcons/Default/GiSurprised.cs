// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSurprised : ComponentBase
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
		builder.AddAttribute(14, "d", "M119.75 21.125l46.313 85.97L19.53 77.904l110.595 88.22-95.53 21.906 118.81 32.532-54.218 49.032 89.876-7.22c-1.908-9.424-2.938-19.26-2.938-29.405 0-33.145 10.464-63.34 27.875-85.595 17.41-22.254 42.197-36.688 69.813-36.688.447 0 .898.024 1.343.032L258.25 26.312 234.78 93.72 119.75 21.124zm164.063 108.25c-21.154 0-40.524 10.877-55.094 29.5-14.572 18.623-23.907 44.906-23.907 74.094 0 30.247 10.36 57.38 25.937 76.155l10.125 12.22-15.594 2.936c-44.37 8.354-65.334 25.41-77.5 54.033-11.426 26.885-13.802 65.837-14.06 115.625h46.186v-50.75h18.688v50.75h167.53v-50.75h18.72v50.75h50.53c-.03-50.187-.558-90.043-10.937-117.282-11.042-28.982-31.384-46.105-79.75-53.72l-15.875-2.498 10.032-12.532c14.82-18.577 23.97-45.282 23.97-74.937-.002-29.19-9.337-55.472-23.908-74.095-14.57-18.623-33.94-29.5-55.094-29.5zM251.905 193.5c12.803 0 23.188 17.03 23.188 38.063 0 21.035-10.385 38.093-23.188 38.093-12.802 0-23.187-17.058-23.187-38.094 0-21.035 10.384-38.062 23.186-38.062zm64.406 0c12.803 0 23.188 17.03 23.188 38.063 0 21.035-10.385 38.093-23.188 38.093-12.802 0-23.187-17.058-23.187-38.094 0-21.035 10.385-38.062 23.188-38.062z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
