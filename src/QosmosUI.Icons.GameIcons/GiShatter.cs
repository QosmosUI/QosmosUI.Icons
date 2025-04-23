// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiShatter : ComponentBase
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
		builder.AddAttribute(14, "d", "M326.594 14.97l-39.78 45.468L285.717 170l52.56-95.78-11.686-59.25zM204.438 27.78l-8.25 72.095 53.03 95.063-1.562-108.875-43.22-58.282zM69.75 61.157l35.438 74.28 105.187 77.75-37.72-78.874L69.75 61.156zm365.72 20.25l-66.564 28.875-55.812 93.5 93.5-55.81 28.875-66.564zm.28 91.094l-75 53.063L449.53 223 495 180l-59.25-7.5zm-159.063 21.375l-11.968 38.28-35.908-29.905 13.157 50.875-51.47 18.53 50.28 7.783-11.968 58.062 29.844-36.063 15.97 20.375-.345-46.562 35.94 7.78-11.97-26.905 43.063-41.313-46.063 11.97-18.563-32.907zm-259.218 5.28l91.75 50.94 94.843-.94-81.657-48.218-104.937-1.78zm376.592 47.782l-58.656 20.782 94.094 15.874 62.313-22-97.75-14.656zM81.156 279.063l-45.47 39.75 59.252 11.72 75-47.688-88.782-3.78zm244.22 16.188l78.093 75.875 71.78 10.656-45.125-56.81-104.75-29.72zm-107.22 3.906l-88.97 50.188-58.155 96.906 96.907-58.156 50.22-88.938zm75.47 2.625l15.812 104.158 73.375 76-24.97-108.657-64.218-71.5zm-31.907 40.814l-22 62.344 15.905 94.093 20.78-58.655-14.686-97.78zm-44.19 24.937l-54.374 75.033 6.438 59.25 43.812-45.47 4.125-88.812z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
