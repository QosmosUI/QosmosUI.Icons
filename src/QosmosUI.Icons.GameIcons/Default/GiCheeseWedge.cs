// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCheeseWedge : ComponentBase
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
		builder.AddAttribute(14, "d", "M265.625 44.094c-11.92-.006-23.856.406-35.72 1.28l-8.75 7.407c10.17 6.262 17 15.568 18.782 26.064 1.987 11.69-2.516 24.07-12.125 33.562-19.217 18.984-51.41 23.684-75.718 11.344-3.116-1.582-5.967-3.43-8.53-5.5L16.75 225.28l73.844-19.374c7.536-18.897 26.34-33.647 48.312-37.594 3.574-.64 7.115-.964 10.563-.968 10.34-.013 19.93 2.784 27.655 8.125 2.484 1.716 4.762 3.703 6.78 5.936l292.376-76.72c-44.976-39.156-127.223-60.55-210.655-60.592zm224.97 74.687l-298.22 77.72c1.1 3.658 1.72 7.54 1.72 11.563 0 27.05-23.283 50.49-51.876 55.625-14.298 2.567-27.89-.067-38.19-7.188-10.298-7.12-16.968-19.036-16.968-32.563L19.69 241.5v95.375c.307-.08.527-.21.843-.28 14.397-3.31 28.193-1.258 38.69 5.592 10.495 6.85 17.25 18.793 17.25 32.407 0 27.227-23.146 51.74-51.876 58.344-1.705.39-3.29.547-4.907.75v13.218l202.563-52.812c-2.63-5.602-4.063-11.73-4.063-18.156 0-26.515 24.672-48.032 55.125-48.032 26.018 0 47.824 15.708 53.625 36.813 1.365.34 2.746.686 4.125 1.06l159.532-41.092V118.78zm-341.126 67.25c-2.306.005-4.726.204-7.25.657-20.205 3.63-36.47 21.794-36.47 37.25 0 7.73 3.215 13.253 8.906 17.188 5.69 3.935 14.148 5.97 24.25 4.156 20.204-3.628 36.5-21.76 36.5-37.218 0-7.728-3.215-13.283-8.906-17.218-4.268-2.952-10.118-4.823-17.03-4.813zm247.468 64.032c20.694 0 38.843 15.04 38.843 35.032 0 19.992-18.148 35.062-38.842 35.062-20.695 0-38.875-15.07-38.875-35.062 0-19.992 18.18-35.03 38.875-35.03zm0 18.688c-11.896 0-20.188 7.946-20.188 16.344 0 8.397 8.292 16.344 20.188 16.344 11.895 0 20.156-7.947 20.156-16.344 0-8.398-8.26-16.344-20.156-16.344z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
